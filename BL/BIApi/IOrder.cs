
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{   
    public interface IOrder
    {
        List<SaleInProduct> AddProductToOrder(Order order,int code,int amount);
        void CalcTotalPriceForProduct(Product product);
        void DoOrder(Order order);
        void SearchSaleForProduct(ProductInOrder productInOrder, bool isFavorite);

    }
}
