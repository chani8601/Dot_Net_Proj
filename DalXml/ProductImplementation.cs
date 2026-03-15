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
    internal class ProductImplementation : IProduct
    {
        const string PRODUCTS_FILE_PATH = "../xml/products.xml";
        private List<Product> Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            if (!File.Exists(PRODUCTS_FILE_PATH))
                return new List<Product>();

            using StreamReader sr = new StreamReader(PRODUCTS_FILE_PATH);
            return serializer.Deserialize(sr) as List<Product> ?? new List<Product>();
        }
        private void saveList(List<Product> prod)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using StreamWriter sw = new StreamWriter(PRODUCTS_FILE_PATH);
            serializer.Serialize(sw, prod);
        }
        private int Create(Product prod)
        {
            List<Product> products = Load();
            if (products.Any(p => p.id == prod.id))
                throw new DalAlreadyExistsException(prod.name, prod.id);
            products.Add(prod);
            saveList(products);
            return prod.id;
        }
        private void Delete(int id)
        {
            List<Product> products = Load();
            var productsToDelete = products.SingleOrDefault(p => p.Id == id);
            if (productsToDelete == null)
                throw new DalNotFoundException("Product", id);
            products.Remove(cust);
            saveList(products);
        }
        private void Update(Product prod)
        {
            List<Product> products = Load();
            var productsToUpdate = products.FindIndex(p => p.id == prod.id);
            if (productsToUpdate == -1)
                throw new DalNotFoundException(prod.name, prod.id);
            products[productsToUpdate] = prod;
            saveList(products);
        }
        private Product Read(int id)
        {
            List<Product> products = Load();
            var productsToUpdate = products.FirstOrDefault(p => p.id == id);
            if (productsToUpdate == null)
                throw new DalNotFoundException("Product", id);
            return productsToUpdate;
        }
        public Product? Read(Func<Product, bool> filter)
        {
            List<Product> products = LoadList();
            var prod = products.FirstOrDefault(filter);
            if (prod == null)
                throw new DalIdNotFoundException("Product","id not found");
            return prod;
        }
        public List<Product> ReadAll()
        {
            XElement root = XElement.Load("../xml/products.xml");

            var products =
                from c in root.Elements("Product")
                select new product
                {
                    Id = (int)p.Element("Id"),
                    Name = (string)p.Element("Name"),
                    Phone = (string?)p.Element("Phone")
                };

            return products.ToList();
        }
    }
}

