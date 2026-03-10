using DO;
using DalApi;
using Dal;

namespace Dal
{
    public class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            if (!DataSource.customers.Any(Customer => Customer.Id == item.Id))
            {
                DataSource.customers.Add(item);
                return item.Id;
            }
            throw new DO.DalAlreadyExistsException("customer", item.Id);
        }

        public Customer Read(int id)
        {
            var customer = DataSource.customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                throw new DalNotFoundException("Customer", id);

            return customer;
        }

        public List<Customer> ReadAll(Func<Customer,bool>? filter = null)
        {
            if (filter == null)
                return new List<Customer>(DataSource.customers);
            return DataSource.customers.Where(filter).ToList();
        }

        public void Delete(int id)
        {
            int removed = DataSource.customers.RemoveAll(cu => cu.Id == id);

            if (removed == 0)
                throw new DalNotFoundException("Customers", id);
        }

        public void Update(Customer c)
        {
            Delete(c.Id);
            DataSource.customers.Add(c);
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            var c= DataSource.customers.FirstOrDefault(filter);
            if (c != null)
                return c;
            throw new Exception("The customer was not found according to the requested condition.\r\n");
            //throw new DalNotFoundException("Customer",0);
        }
    }
}
