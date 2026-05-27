using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(int Id, string ?NameP,category Category,double Price,int Amount)
    {
        public Product():this(0,"",category.Breads,0.0,0)
        {
            
        }
    }
}
