using DalApi;
using DO;
using System.Xml.Serialization;
using static Dal.DalExceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string SALE_FILE_PATH = "../xml/sales.xml";
        private List<Sale> Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            if (!File.Exists(SALE_FILE_PATH))
                return new List<Sale>();

            using StreamReader sr = new StreamReader(SALE_FILE_PATH);
            return serializer.Deserialize(sr) as List<Sale> ?? new List<Sale>();
        }
        private void saveList(List<Sale> prod)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using StreamWriter sw = new StreamWriter(SALE_FILE_PATH);
            serializer.Serialize(sw, prod);
        }
        private int Create(Sale prod)
        {
            List<Sale> sales = Load();
            if (sales.Any(p => p.id == prod.id))
                throw new DalAlreadyExistsException(prod.name, prod.id);
            sales.Add(prod);
            saveList(sales);
            return prod.id;
        }
        private void Delete(int id)
        {
            List<Sale> sales = Load();
            var psalesToDelete = sales.SingleOrDefault(s => s.Id == id);
            if (salesToDelete == null)
                throw new DalNotFoundException("Sale", id);
            sales.Remove(cust);
            saveList(sales);
        }
        private void Update(Sale sal)
        {
            List<Sale> sales = Load();
            var salesToUpdate = sales.FindIndex(s => s.id == sal.id);
            if (salesToUpdate == -1)
                throw new DalNotFoundException(sal.name, sal.id);
            sales[salesToUpdate] = sal;
            saveList(sales);
        }
        private Sale Read(int id)
        {
            List<Sale> sales = Load();
            var salesToUpdate = sales.FirstOrDefault(s => s.id == id);
            if (salesToUpdate == null)
                throw new DalNotFoundException("Sale", id);
            return salesToUpdate;
        }
        public Sale? Read(Func<Sale, bool> filter)
        {
            List<Sale> sales = LoadList();
            var sal = sales.FirstOrDefault(filter);
            if (sal == null)
                throw new DalIdNotFoundException("Sale", "id not found");
            return sal;
        }
        public List<Sale> ReadAll()
        {
            XElement root = XElement.Load("../xml/sales.xml");

            var sales =
                from c in root.Elements("Sale")
                select new sale
                {
                    Id = (int)s.Element("Id"),
                    Name = (string)s.Element("Name"),
                    Phone = (string?)s.Element("Phone")
                };

            return sales.ToList();
        }
    }
}


