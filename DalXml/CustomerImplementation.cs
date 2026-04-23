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
    internal class CustomerImplementation:ICustomer
    {
        const string CUSTOMERS_FILE_PATH = "../xml/customers.xml";
        public List<Customer> Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            if(!File.Exists(CUSTOMERS_FILE_PATH))
                return new List<Customer> ();

            using StreamReader sr = new StreamReader(CUSTOMERS_FILE_PATH);
            return serializer.Deserialize(sr) as List<Customer> ?? new List<Customer>();
        }
        public void saveList(List<Customer>customer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using StreamWriter sw=new StreamWriter(CUSTOMERS_FILE_PATH);
            serializer.Serialize(sw,customer);
        }
        public int Create(Customer cust)
        {
            List<Customer> customers = Load();
            if(customers.Any(c=>c.Id== cust.Id))
                throw new DalAlreadyExistsException(cust.Name,cust.Id);
            customers.Add(cust);
            saveList(customers);
            return cust.Id;
        }
        public void Delete(int id)
        {
            List<Customer> customers = Load();
            var customerToDelete = customers.SingleOrDefault(c => c.Id == id);
            if (customerToDelete==null)
                throw new DalNotFoundException("customer", id);
            customers.Remove(cus);
            saveList(customers);
        }
        public void Update(Customer cust)
        {
            List<Customer>customer=Load();
            var customerToUpdate = customer.FindIndex(c => c.Id== cust.Id);
            if(customerToUpdate==-1)
                throw new DalNotFoundException(cust.Name, cust.Id);
            customer[customerToUpdate] = cust;  
            saveList(customer);
        }
        public Customer Read(int id)
        {
            List<Customer> customer = Load();
            var customerToUpdate = customer.FirstOrDefault(c => c.Id == id);
            if (customerToUpdate == null)
                throw new DalNotFoundException("customer", id);
            return customerToUpdate;
        }
        public Customer? Read(Func<Customer, bool> filter)
        {
            List<Customer> customersList = LoadList();
            var customer = customersList.FirstOrDefault(filter);
            if (customer == null)
                throw new DalNotFoundException("No customer found matching the filter",customer.Id);
            return customer;
        }
        public List<Customer> ReadAll()
        {
            XEle root = XElement.Load("../xml/customers.xml");

            var customers =
                from c in root.Elements("Customer")
                select new Customer
                {
                    Id = (int)c.Element("Id"),
                    Name = (string)c.Element("Name"),
                    Phone = (string?)c.Element("Phone")
                };

            return customers.ToList();
        }
    }
}
