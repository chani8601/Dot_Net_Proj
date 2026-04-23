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
            if (products.Any(p => p.Id == prod.Id))
                throw new DalAlreadyExistsException(prod.NameP, prod.Id);
            products.Add(prod);
            saveList(products);
            return prod.Id;
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
            var productsToUpdate = products.FindIndex(p => p.Id == prod.Id);
            if (productsToUpdate == -1)
                throw new DalNotFoundException(prod.NameP, prod.Id);
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
                throw new DalNotFoundException("Product id not found",prod.Id );
            return prod;
        }
        public List<Product> ReadAll()
        {
            XElement root = XElement.Load("../xml/products.xml");

            var products =
                from c in root.Elements("Product")
                select new Product
                {
                    Id = (int)p.Element("Id"),
                    NameP = (string)p.Element("Name"),
                    //Phone = (string?)p.Element("Phone")
                };

            return products.ToList();
        }
    }
}

