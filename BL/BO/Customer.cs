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




        public Customer(int Customer_Id, string? Customer_Name, string? Customer_Address, string Customer_Phone)
        {
           this. Customer_Id = Customer_Id;
            this.Customer_Name = Customer_Name;
            this.Customer_Address = Customer_Address;
            this.Customer_Phone = Customer_Phone;
        }
        public int Customer_Id { get; set; }
        public string? Customer_Name { get; set; }
        public string? Customer_Address { get; set; }
        public string Customer_Phone { get; set; }

        internal DO.Customer ConvertBoCustomerToDoCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
