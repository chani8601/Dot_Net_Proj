//using BIImplementation.BO;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface IProduct
    {
      
        int Create(Product item);
        Product? Read(int id);
        void Update(Product item);
        void Delete(int id);
        List<Product?> ReadAll(Func<Product, bool>? filter = null);
        Product? Read(Func<Product, bool> filter);
        void UpdateValidSalesForProduct(int code, bool isFavorite);
    }
}
