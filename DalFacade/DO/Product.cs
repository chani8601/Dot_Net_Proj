using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(int Id, string ?NameP,category Category,double Price,int Amount)
    {
        public int Id { get; set; } = Id;
        public string? NameP { get; set; } = NameP;
        public category Category { get; set; } = Category;
        public double Price { get; set; } = Price;
        public int Amount { get; set; } = Amount;
        public Product():this(0,"",category.c1,0.0,0)
        {
            
        }
    }
}
