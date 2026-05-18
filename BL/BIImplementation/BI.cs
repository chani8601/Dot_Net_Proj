using BIApi;
using BIImplementation;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BIImplementation
{
    internal class BI : IBI
    {
     public ICustomer Customer =>  new CustomerImplementation();

        public IOrder Order => new OrderImplementation();//לתקן אחרי שמסדרים את האורדר

        public ISale Sale => new SaleImplementation();

        public IProduct Product => new ProductImplementation();
    }
}
