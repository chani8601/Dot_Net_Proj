using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int Id, string? Name, string? Address, string Phone)
        {
            id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
        }
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }

        internal DO.Customer ConvertBoCustomerToDoCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
