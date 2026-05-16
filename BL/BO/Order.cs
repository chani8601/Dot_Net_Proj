using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool club { get; set; }
        public List<ProductInOrder> products { get; set; }
        public double final_price { get; set; }
        public Order()
        {

        }
        public Order(bool club, List<ProductInOrder> products, double final_price)
        {
            this.club = club;
            this.products = products;
            this.final_price = final_price;
        }
        public override string ToString() => this.ToStringProperty();

    }
}
