using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(int Id,int IdP,int MinAmount,double AllPrice,bool IfEveryone,DateTime StartSale,DateTime EndSale)
    {
        public Sale() : this(0, 0, 0, 0, true, DateTime.Now, DateTime.Now)
        {

        }
    }
}
