using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdP { get; set; }
        public int MinAmount { get; set; }
        public double AllPrice { get; set; }
        public bool IfEveryone { get; set; }
        public DateTime StartSale { get; set; }
        public DateTime EndSale { get; set; }
        public Sale(int Id, int IdP, int MinAmount, double AllPrice, bool IfEveryone, DateTime StartSale, DateTime EndSale)
        {
            this.Id = Id;
            this.IdP = IdP;
            this.MinAmount = MinAmount;
            this.AllPrice = AllPrice;
            this.IfEveryone = IfEveryone;
            this.StartSale = StartSale;
            this.EndSale = EndSale;
        }
        public Sale()
        {

        }
    }
}
