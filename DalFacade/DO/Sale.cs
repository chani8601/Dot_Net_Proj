using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(int Id,int IdP,int MinAmount,double AllPrice,bool IfEveryone,DateTime StartSale,DateTime EndSale)
    {
        public int Id { get; set; } = Id;
        public int IdP { get; set; } = IdP;
        public int MinAmount { get; set; } = MinAmount;
        public double AllPrice { get; set; } = AllPrice;
        public bool IfEveryone { get; set; } = IfEveryone;
        public DateTime StartSale { get; set; } = StartSale;
        public DateTime EndSale { get; set; } = EndSale;
        public Sale():this(0,0,0,0,true,DateTime.Now,DateTime.Now) 
        {
            
        }
    }
}
