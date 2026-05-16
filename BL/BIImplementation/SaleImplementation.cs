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
    internal class SaleImplementation : BIApi.ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.ConvertBoSaleToDoSale());
            }
            catch
            {
                throw new Exception("");//??
            }
        }
        public void Update(Sale item)
        {
            try
            {
                _dal.Sale.Update(item.ConvertBoSaleToDoSale());
            }
            catch 
            {
                throw new Exception();

            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch
            {
                throw new Exception();
            }
        }
        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.ConvertDoSaleToBoSale()).ToList();
                else
                    return _dal.Sale.ReadAll(s => filter(s.ConvertDoSaleToBoSale())).Select(s => s.ConvertDoSaleToBoSale()).ToList();
            }
            catch
            {
                throw new Exception();
            }
        }
        public Sale? Read(Func<Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(s => filter(s.ConvertDoSaleToBoSale())).ConvertDoSaleToBoSale();
            }
            catch
            {
                throw new Exception();
            }
        }
        public Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).ConvertDoSaleToBoSale();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
