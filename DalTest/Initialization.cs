using DO;
using DalApi;
using System.Runtime.Intrinsics.Arm;
using Dal;
using System.Data.SqlTypes;
namespace DalTest
{
    public static class Initialization
    {
        //try
        //  private static IDal? s_dal;
        //public static List<int> s_dal = new();

        //לברר האם צריך לאתחל גם את השורה הזאת,הורדתי את האתחול כי עשה לי שגיאה
        private static IDal s_dal;

        public static void Initialize()
        {
            s_dal = DalApi.Factory.Get;

            CreateCustomers();
            CreatProducts();
            CreatSales();
        }
        public static List<int> ids = new();


        // מוסיפים לקוחות
        private static void CreateCustomers()
        {
            //מברכי:
            //s_dal.Customer.Create(new Customer(0, "Dana Levi", "12 Herzl St, Tel Aviv", "050-1234567"));


            s_dal.Customer.Create(new Customer(1, "Tzipi Etinger", "Rashbi 9 Moddin Ilit", "0548409683"));
            s_dal.Customer.Create(new Customer(2, "Chani Avramovich", "Shaarei Tshuva 6 Modiin Ilit", "0504118601"));
        }


        // מוסיפים מוצרים
        private static void CreatProducts()
        {
            //מברכי
            //ids.Add(s_dal.Product.Create(new Product(0, "Goldstar Lager", category.c1, 3.5, 100)));

            s_dal.Product.Create(new Product(111, "", category.c1, 10, 5));
            s_dal.Product.Create(new Product(112, "", category.c2, 20, 8));
        }


        // מוסיפים מבצעים
        private static void CreatSales()
        {
            //מברכי
            //s_dal.Sale.Create(new Sale(0, ids[2], 4, 850.0, false, new DateTime(2025, 3, 1), new DateTime(2025, 3, 31)));

            s_dal.Sale.Create(new Sale(1, 111, 5, 20, true, DateTime.Now, DateTime.Now.AddDays(15)));
            s_dal.Sale.Create(new Sale(2, 112, 2, 10, false, DateTime.Now, DateTime.Now.AddDays(15)));
        }





    }
}
