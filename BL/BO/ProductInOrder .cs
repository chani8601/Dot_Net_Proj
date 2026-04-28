using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int id { get; set; }
        public string name { get; set; }
        public double basic_price { get; set; }
        public int amount { get; set; }
        public List<SaleInProduct> sales { get; set; }
        public double final_price { get; set; }
        public ProductInOrder()
        {

        }
        public ProductInOrder(int id, string name, double basic_price, int amount, List<SaleInProduct> sales, double final_price)
        {
            this.id = id;
            this.name = name;
            this.basic_price = basic_price;
            this.amount = amount;
            this.sales = sales;
            this.final_price = final_price;
        }

    }
}
