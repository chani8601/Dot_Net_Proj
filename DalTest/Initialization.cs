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
            s_dal.Product.Create(new Product(101, "Sourdough Bread",      category.Breads,   18, 20));
            s_dal.Product.Create(new Product(102, "Whole Wheat Bread",    category.Breads,   15, 30));
            s_dal.Product.Create(new Product(103, "Rye Bread",            category.Breads,   17, 25));
            s_dal.Product.Create(new Product(104, "Baguette",             category.Breads,   12, 40));
            s_dal.Product.Create(new Product(105, "Pita Bread",           category.Breads,   8,  60));
            s_dal.Product.Create(new Product(106, "Croissant",            category.Pastries, 12, 50));
            s_dal.Product.Create(new Product(107, "Cheese Bourekas",      category.Pastries, 10, 45));
            s_dal.Product.Create(new Product(108, "Spinach Bourekas",     category.Pastries, 10, 40));
            s_dal.Product.Create(new Product(109, "Mushroom Quiche",      category.Pastries, 22, 20));
            s_dal.Product.Create(new Product(110, "Pretzel",              category.Pastries, 9,  35));
            s_dal.Product.Create(new Product(111, "Chocolate Muffin",     category.Sweets,   14, 35));
            s_dal.Product.Create(new Product(112, "Cinnamon Roll",        category.Sweets,   16, 25));
            s_dal.Product.Create(new Product(113, "Chocolate Croissant",  category.Sweets,   14, 30));
            s_dal.Product.Create(new Product(114, "Cheesecake Slice",     category.Sweets,   22, 15));
            s_dal.Product.Create(new Product(115, "Brownie",              category.Sweets,   12, 40));
            s_dal.Product.Create(new Product(116, "Fresh Orange Juice",   category.Drinks,   20, 15));
            s_dal.Product.Create(new Product(117, "Coffee",               category.Drinks,   12, 60));
            s_dal.Product.Create(new Product(118, "Cappuccino",           category.Drinks,   16, 50));
            s_dal.Product.Create(new Product(119, "Hot Chocolate",        category.Drinks,   14, 30));
            s_dal.Product.Create(new Product(120, "Lemonade",             category.Drinks,   18, 25));
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
