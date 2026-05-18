using BIApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BO;
using BO;
using DalApi;
using System.Reflection;
using static BO.Tools;


namespace BIImplementation
{
    internal class CustomerImplementation : BIApi. ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new Exception("");
            }

        }
        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch
            {
                throw new Exception("");
            }
        }

        public bool IsCustomerExist(int id)
        {
            try
            {
                _dal.Customer.Read(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public BO.Customer?Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).ConvertDoCustomerToBoCustomer();
            }
            catch
            {
                throw new Exception();
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Customer.ReadAll().Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
                else
                    return _dal.Customer.ReadAll(s => filter(s.ConvertDoCustomerToBoCustomer())).Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
            }
            catch
            {
                throw new Exception("");
            }
        }
        public void Update(BO.Customer customer)
        {
            try
            {
                _dal.Customer.Update(customer.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new Exception();  
            }
        }



    }
}
