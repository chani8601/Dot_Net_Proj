using DalApi;
using DO;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        const string PRODUCTS_FILE_PATH = "../xml/products.xml";
        //private List<Product> Load()
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        //    if (!File.Exists(PRODUCTS_FILE_PATH))
        //        return new List<Product>();

        //    using StreamReader sr = new StreamReader(PRODUCTS_FILE_PATH);
        //    return serializer.Deserialize(sr) as List<Product> ?? new List<Product>();
        //}

        private List<Product> Load()
        {
            if (!File.Exists(PRODUCTS_FILE_PATH))
                return new List<Product>();

            if (new FileInfo(PRODUCTS_FILE_PATH).Length == 0)
                return new List<Product>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using StreamReader sr = new StreamReader(PRODUCTS_FILE_PATH);
                return serializer.Deserialize(sr) as List<Product> ?? new List<Product>();
            }
            catch
            {
                return new List<Product>(); // ⭐ קריטי
            }
        }
        private void saveList(List<Product> prod)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using StreamWriter sw = new StreamWriter(PRODUCTS_FILE_PATH);
            serializer.Serialize(sw, prod);
        }

        public int Create(Product prod)
        {
            List<Product> products = Load();

            prod = prod with { Id = Config.ProductNum }; // ⭐ חשוב

            if (products.Any(p => p.Id == prod.Id))
                throw new DalAlreadyExistsException(prod.NameP ?? "Product", prod.Id);
            products.Add(prod);
            saveList(products);
            return prod.Id;
        }

        public void Delete(int id)
        {
            List<Product> products = Load();
            var productsToDelete = products.SingleOrDefault(p => p.Id == id);
            if (productsToDelete == null)
                throw new DalNotFoundException("Product", id);
            products.Remove(productsToDelete);
            saveList(products);
        }

        public void Update(Product prod)
        {
            List<Product> products = Load();
            var productsToUpdate = products.FindIndex(p => p.Id == prod.Id);
            if (productsToUpdate == -1)
                throw new DalNotFoundException(prod.NameP ?? "Product", prod.Id);
            products[productsToUpdate] = prod;
            saveList(products);
        }

        public Product? Read(int id)
        {
            List<Product> products = Load();
            var productsToUpdate = products.FirstOrDefault(p => p.Id == id);
            if (productsToUpdate == null)
                throw new DalNotFoundException("Product", id);
            return productsToUpdate;
        }
        public Product? Read(Func<Product, bool> filter)
        {
            List<Product> products = Load();
            var prod = products.FirstOrDefault(filter);
            if (prod == null)
                throw new DalNotFoundException("Product id not found", 0);
            return prod;
        }
        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            List<Product> products = Load();

            var result = (filter == null ? products : products.Where(filter)).ToList();

            if (result.Count == 0)
                Console.WriteLine("No products found.");

            return result.Cast<Product?>().ToList();
        }
    }
}

