using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public Product(int Id, string? NameP, category Category, double Price, int Amount, List<Product> SaleInProduct)
        {
            this.Id = Id;
            this.NameP = NameP;
            this.Category = Category;
            this.Price = Price;
            this.Amount = Amount;
            this.SaleInProduct = SaleInProduct;
        }
        public Product()
        {

        }
        public int Id { get; set; }
        public string? NameP { get; set; }
        public category Category { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public List<Product> SaleInProduct { get; set; }

    }
}
