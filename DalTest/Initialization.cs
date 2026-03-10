using DO;
using DalApi;
using System.Runtime.Intrinsics.Arm;
using Dal;


namespace DalTest
{
    public static class Initialization
    {
        
        private static IDal? s_dal;



        // מוסיפים לקוחות
        private static void CreateCustomers()
        {
            s_dal.Customer.Create(new Customer (1, "Tzipi Etinger", "Rashbi 9 Moddin Ilit","0548409683" ));
            s_dal.Customer.Create(new Customer (2, "Chani Avramovich", "Shaarei Tshuva 6 Modiin Ilit" ,"0504118601"));
        }


        // מוסיפים מוצרים
        private static void CreatProducts() 
        {
            s_dal.Product.Create(new Product(111, "", category.c1, 10, 5));
            s_dal.Product.Create(new Product(112, "", category.c2, 20, 8));
        }


        // מוסיפים מבצעים
        private static void CreatSales()
        {
            s_dal.Sale.Create(new Sale (1, 111, 5, 20,  true, DateTime.Now, DateTime.Now.AddDays(15)));
            s_dal.Sale.Create(new Sale (2, 112, 2, 10, false, DateTime.Now, DateTime.Now.AddDays(15)));
        }


        public static void Initialize()
        {
            s_dal = new DalList();
            CreateCustomers();
            CreatProducts();
            CreatSales();
        }


    }
}

