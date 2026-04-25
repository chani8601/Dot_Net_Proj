using DalApi;
using DO;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dal
{
    internal class CustomerImplementation:ICustomer
    {
        private static readonly string CUSTOMERS_FILE_PATH = "../xml/customers.xml";

        private XElement LoadXml() =>
            File.Exists(CUSTOMERS_FILE_PATH) ? XElement.Load(CUSTOMERS_FILE_PATH) : new XElement("ArrayOfCustomer");

        private void SaveXml(XElement root) => root.Save(CUSTOMERS_FILE_PATH);

        private static Customer ToCustomer(XElement c) => new Customer(
            (int)c.Element("Id")!,
            (string?)c.Element("Name"),
            (string?)c.Element("Address"),
            (string)c.Element("Phone")! ?? ""
        );

        private static XElement ToXElement(Customer cust) => new XElement("Customer",
            new XElement("Id", cust.Id),
            cust.Name != null ? new XElement("Name", cust.Name) : null!,
            cust.Address != null ? new XElement("Address", cust.Address) : null!,
            new XElement("Phone", cust.Phone)
        );
        public int Create(Customer cust)
        {
            XElement root = LoadXml();
            if (root.Elements("Customer").Any(c => (int)c.Element("Id")! == cust.Id))
                throw new DalAlreadyExistsException(cust.Name ?? "Customer", cust.Id);
            root.Add(ToXElement(cust));
            SaveXml(root);
            return cust.Id;
        }
        public void Delete(int id)
        {
            XElement root = LoadXml();
            var customerToDelete = root.Elements("Customer").SingleOrDefault(c => (int)c.Element("Id")! == id);
            if (customerToDelete == null)
                throw new DalNotFoundException("customer", id);
            customerToDelete.Remove();
            SaveXml(root);
        }
        public void Update(Customer cust)
        {
            XElement root = LoadXml();
            var customerToUpdate = root.Elements("Customer").SingleOrDefault(c => (int)c.Element("Id")! == cust.Id);
            if (customerToUpdate == null)
                throw new DalNotFoundException(cust.Name ?? "Customer", cust.Id);
            customerToUpdate.ReplaceWith(ToXElement(cust));
            SaveXml(root);
        }
        public Customer? Read(int id)
        {
            XElement root = LoadXml();
            var c = root.Elements("Customer").SingleOrDefault(c => (int)c.Element("Id")! == id);
            if (c == null)
                throw new DalNotFoundException("customer", id);
            return ToCustomer(c);
        }
        public Customer? Read(Func<Customer, bool> filter)
        {
            var customer = ReadAll().Cast<Customer>().FirstOrDefault(filter);
            if (customer == null)
                throw new DalNotFoundException("No customer found matching the filter", 0);
            return customer;
        }
        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            XElement root = LoadXml();
            var customers = root.Elements("Customer").Select(ToCustomer);
            return (filter == null ? customers : customers.Where(filter)).Cast<Customer?>().ToList();
        }
    }
}
