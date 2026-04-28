using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public static class Tools
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

        public static DO.Product ConvertDoProductToBoProduct(this BO.Product product) 
        {
            return new DO.Product(product.Id, product.NameP, product.Category, product.Price, product.Amount);
        }

    }
}
