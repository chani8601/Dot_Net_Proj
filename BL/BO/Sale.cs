using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int MinAmountSale { get; set; }
        public double Price_Sale { get; set; }
        public bool If_All_Customers { get; set; }
        public DateTime Date_Start_Sale { get; set; }
        public DateTime DateEndSale { get; set; }
        public Sale(int SaleId, int ProductId, int MinAmountSale, double Price_Sale, bool If_All_Customers, DateTime Date_Start_Sale, DateTime DateEndSale)
        {
            this.SaleId = SaleId;
            this.ProductId = ProductId;
            this.MinAmountSale = MinAmountSale;
            this.Price_Sale = Price_Sale;
            this.If_All_Customers = If_All_Customers;
            this.Date_Start_Sale = Date_Start_Sale;
            this.DateEndSale = DateEndSale;
        }
        public Sale()
        {

        }
    }
}

