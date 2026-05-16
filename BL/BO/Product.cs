using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public Product(int Product_Id, string? Product_Name, DO.category Product_Category, double Product_Price, int Product_Amount, List<Product> SaleInProduct)
        {
            this.Product_Id = Product_Id;
            this.Product_Name = Product_Name;
            this.Product_Category = Product_Category;
            this.Product_Price = Product_Price;
            this.Product_Amount = Product_Amount;
            this.SaleInProduct = SaleInProduct;
        }
        public Product()
        {

        }
        public int Product_Id { get; set; }
        public string? Product_Name { get; set; }
        public DO.category Product_Category { get; set; }
        public double Product_Price { get; set; }
        public int Product_Amount { get; set; }
        public List<Product> SaleInProduct { get; set; }

    }
}
