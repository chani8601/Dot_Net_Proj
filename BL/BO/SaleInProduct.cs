using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int id { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public bool if_everyone { get; set; }
        public SaleInProduct()
        {

        }
        public SaleInProduct(int id, int amount, double price, bool if_everyone)
        {
            this.id = id;
            this.amount = amount;
            this.price = price;
            this.if_everyone = if_everyone;
        }
    }
}
