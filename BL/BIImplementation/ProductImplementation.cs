using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BIImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.ConvertBoProductToDoProduct());
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
                _dal.Product.Delete(id);
            }
            catch
            {
                throw new Exception("");
            }
        }
        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id).ConvertBoProductToDoProduct();
            }
            catch
            {
                throw new Exception();
            }
        }
        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(s => filter(s.ConvertDoProductToBoProduct())).ConvertDoProductToBoProduct();
            }
            catch
            {
                throw new Exception();
            }

        }
        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(s => s.ConvertBoProductToDoProduct()).ToList();
                else
                    return _dal.Product.ReadAll(s => filter(s.ConvertBoProductToDoProduct())).Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
            }
            catch
            {
                throw new Exception("");
            }
        }
        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ConvertBoProductToDoProduct());
            }
            catch
            {
                throw new Exception();
            }
        }
        public void UpdateValidSalesForProduct(int code, bool isFavorite)
        {

        }

    }
}
