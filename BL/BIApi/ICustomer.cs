using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface ICustomer
    {
        int Create(Customer item);
        Customer? Read(int id);
        void Update(Customer item);
        void Delete(int id);
        List<Customer?> ReadAll(Func<Customer, bool>? filter = null);
        Customer? Read(Func<Customer, bool> filter);
        bool IsCustomerExist(int customerId);
    }
}
