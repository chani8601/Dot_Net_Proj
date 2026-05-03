using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
﻿using DO;


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
            return new DO.Customer(customer.Customer_Id, customer.Customer_Address, customer.Customer_Phone, customer.Customer_Name);
        }

        public static BO.Customer ConvertDoCustomerToBoCustomer(this DO.Customer customer)
        {
            return new BO.Customer()
            {
                Customer_Id = customer.,
                Customer_Name = customer.Customer_Name,
                Customer_Phone = customer.Customer_Phone,
                Customer_Address = customer.Customer_Address
            };

        }





        //public static DO.Product ConvertBoProductToDoProduct(this BO.Product product)
        //{
        //    return new DO.Product(product.Product_Id, product.Product_Name, product.Price, product.Count, (DO.categoryProduct)product.category);
        //}

        //public static BO.Product ConvertDoProductToBoProduct(this DO.Product product)
        //{
        //    return new BO.Product()
        //    {
        //        Product_Id = product.Product_Id,
        //        Product_Name = product.Product_Name,
        //        Price = product.Price,
        //        Count = product.Count,
        //        category = (BO.categoryProduct)product.category
        //    };

        //}







        //public static DO.Sale ConvertBoSaleToDoSale(this BO.Sale sale)
        //{
        //    return new DO.Sale(sale.SaleId, sale.ProductId, sale.Price_Sale, sale.If_All_Customers, sale.Date_Start_Sale, sale.Count_Sale, sale.Date_End_Sale);
        //}

        //public static BO.Sale ConvertDoSaleToBoSale(this DO.Sale sale)
        //{
        //    return new BO.Sale()
        //    {
        //        SaleId = sale.SaleId,
        //        ProductId = sale.ProductId,
        //        Price_Sale = sale.Price_Sale,
        //        If_All_Customers = sale.If_All_Customers,
        //        Date_Start_Sale = sale.Date_Start_Sale,
        //        Count_Sale = sale.Count_Sale,
        //        Date_End_Sale = sale.Date_End_Sale,
        //    };

        //}
    }
}
