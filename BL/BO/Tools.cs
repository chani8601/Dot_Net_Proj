using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BO
{
    internal static class Tools
    {



        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type type = t.GetType();
            PropertyInfo[] info = type.GetProperties(); 
            foreach (PropertyInfo pi in info)
            {
                str += string.Format("name:{0-15} value {1-15} ", pi.Name, pi.GetValue(t));
            }
            return str;

        }
        public static DO.Customer ConvertBoCustomerToDoCustomer(this BO.Customer customer)
        {
            return new DO.Customer(customer.Customer_Id, customer.Customer_Name, customer.Customer_Address, customer.Customer_Phone);
        }

        public static BO.Customer ConvertDoCustomerToBoCustomer(this DO.Customer customer)
        {
            return new BO.Customer()
            {
                Customer_Id = customer.Id,
                Customer_Name = customer.Name,
                Customer_Phone = customer.Phone,
                Customer_Address = customer.Address
            };

        }





        public static DO.Product ConvertBoProductToDoProduct(this BO.Product product)
        {
            return new DO.Product(product.Product_Id, product.Product_Name, product.Product_Category, product.Product_Price, product.Product_Amount);
        }

        public static BO.Product ConvertDoProductToBoProduct(this DO.Product product)
        {
            return new BO.Product()
            {
                Product_Id = product.Id,
                Product_Name = product.NameP,
                Product_Price = product.Price,
                Product_Amount = product.Amount,
                Product_Category = product.Category
            };

        }



        public static DO.Sale ConvertBoSaleToDoSale(this BO.Sale sale)
        {
            return new DO.Sale(sale.SaleId, sale.ProductId, sale.MinAmountSale, sale.Price_Sale, sale.If_All_Customers, sale.Date_Start_Sale, sale.DateEndSale);
        }

        public static BO.Sale ConvertDoSaleToBoSale(this DO.Sale sale)
        {
            return new BO.Sale()
            {
                SaleId = sale.Id,
                ProductId = sale.IdP,
                Price_Sale = sale.AllPrice,
                If_All_Customers = sale.IfEveryone,
                Date_Start_Sale = sale.StartSale,
                MinAmountSale = sale.MinAmount,
                DateEndSale = sale.EndSale,
            };

        }
    }
}
