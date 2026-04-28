using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;

namespace BIImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        List<SaleInProduct> AddProductToOrder(Order order, int code, int amount)
        {

        }
        void CalcTotalPriceForProduct(Product product)
        {

        }
        void CalcTotalPrice(BO.Order order)
        {

        }
        void DoOrder(Order order)
        {

        }
        void SearchSaleForProduct(ProductInOrder productInOrder, bool isFavorite)
        {

        }
    }
}
