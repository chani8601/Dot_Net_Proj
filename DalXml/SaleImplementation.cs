using DalApi;
using DO;
using System.Xml.Serialization;
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
            if (!File.Exists(SALE_FILE_PATH))
                return new List<Sale>();

            if (new FileInfo(SALE_FILE_PATH).Length == 0)
                return new List<Sale>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
                using StreamReader sr = new StreamReader(SALE_FILE_PATH);
                return serializer.Deserialize(sr) as List<Sale> ?? new List<Sale>();
            }
            catch
            {
                return new List<Sale>();
            }
        }
        private void saveList(List<Sale> prod)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using StreamWriter sw = new StreamWriter(SALE_FILE_PATH);
            serializer.Serialize(sw, prod);
        }
        public int Create(Sale sal)
        {
            List<Sale> sales = Load();
            //לברר האם באמת כך נכון
            sal = sal with { Id = Config.SaleNum };
            if (sales.Any(p => p.Id == sal.Id))
                throw new DalAlreadyExistsException("prod already exist", sal.Id);
            sales.Add(sal);
            saveList(sales);
            return sal.Id;
        }
        public void Delete(int id)
        {
            List<Sale> sales = Load();
            var salesToDelete = sales.SingleOrDefault(s => s.Id == id);
            if (salesToDelete == null)
                throw new DalNotFoundException("Sale", id);
            sales.Remove(salesToDelete);
            saveList(sales);
        }
        public void Update(Sale sal)
        {
            List<Sale> sales = Load();
            var salesToUpdate = sales.FindIndex(s => s.Id == sal.Id);
            if (salesToUpdate == -1)
                throw new DalNotFoundException("Sale", sal.Id);
            sales[salesToUpdate] = sal;
            saveList(sales);
        }
        public Sale? Read(int id)
        {
            List<Sale> sales = Load();
            var salesToUpdate = sales.FirstOrDefault(s => s.Id == id);
            if (salesToUpdate == null)
                throw new DalNotFoundException("Sale", id);
            return salesToUpdate;
        }
        public Sale? Read(Func<Sale, bool> filter)
        {
            List<Sale> sales = Load();
            var sal = sales.FirstOrDefault(filter);
            if (sal == null)
                throw new DalNotFoundException("Sale", 0);
            return sal;
        }
        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            List<Sale> sales = Load();
            return (filter == null ? sales : sales.Where(filter)).Cast<Sale?>().ToList();
        }
    }
}


