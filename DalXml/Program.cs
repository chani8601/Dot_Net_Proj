using DalApi;
using Dal;
using System.Security.Cryptography.X509Certificates;
using DO;
using System.Runtime.Intrinsics.X86;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace DalTest
{
    internal class Program
    {
        private static IDal s_dal = DalApi.Factory.Get;

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Do you want to initialize data? (y/n)");
                //if (Console.ReadLine()?.ToLower() == "y")
                //    Initialization.Initialize();
                if (Console.ReadLine()?.ToLower() == "y")
                    Console.WriteLine("Initialization not available in DalXml");
                MainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("Choose a departement");
            Console.WriteLine("1 for Products");
            Console.WriteLine("2 for Sales");
            Console.WriteLine("3 for Customers");
            Console.WriteLine("4 to Quit");
            int ans;
            int.TryParse(Console.ReadLine(), out ans);
            switch (ans)
            {
                case 1: MenuProduct(s_dal.Product); break;
                case 2: MenuSales(s_dal.Sale); break;
                case 3: MenuCustomer(s_dal.Customer); break;
                default: break;
            }
        }


        public static int PrintMenu(string st)
        {
            Console.WriteLine($"for view all {st}s press 0");
            Console.WriteLine($"for create a new {st} press 1");
            Console.WriteLine($"for getting a element {st} press 2");
            Console.WriteLine($"for delete a element {st} press 3");
            Console.WriteLine($"for update a element {st} press 4");
            Console.WriteLine($"For returning to the main menu press 5");
            Console.WriteLine($"For quiting press any other key");
            int ans;
            int.TryParse(Console.ReadLine(), out ans);
            return ans;
        }
        public static void MenuProduct(IProduct iproduct)
        {
            int ans = PrintMenu("Product");
            switch (ans)
            {
                case 0: ReadAll(iproduct);MenuProduct(iproduct); break;
                case 1: ProductCreate(iproduct);MenuProduct(iproduct);break;
                case 2: Read(iproduct); MenuProduct(iproduct); break;
                case 3: Delete(iproduct); MenuProduct(iproduct); break;
                case 4: ProductUpdate(iproduct); MenuProduct(iproduct); break;
                case 5: MainMenu(); break;
                default : break;
            }

        }
        public static void MenuSales(ISale isale)
        {
            int ans = PrintMenu("Sale");
            switch (ans)
            {
                case 0: ReadAll(isale); MenuSales(isale); break;
                case 1: SaleCreate(isale); MenuSales(isale); break;
                case 2: Read(isale); MenuSales(isale); break;
                case 3: Delete(isale); MenuSales(isale); break;
                case 4: SaleUpdate(isale); MenuSales(isale); break;
                case 5: MainMenu(); break;
                default: break;
            }
        }
        public static void MenuCustomer(ICustomer icustomer)
        {
            int ans = PrintMenu("Customer");
            switch (ans)
            {
                case 0: ReadAll(icustomer); MenuCustomer(icustomer); break;
                case 1: CustomerCreate(icustomer); MenuCustomer(icustomer); break;
                case 2: Read(icustomer); MenuCustomer(icustomer); break;
                case 3: Delete(icustomer); MenuCustomer(icustomer); break;
                case 4: CustomerUpdate(icustomer); MenuCustomer(icustomer); break;
                case 5: MainMenu(); break;
                default: break;
            }
        }

  


        //Create
        private static void ProductCreate(IProduct iproduct)
        {
            Product p = ProductAskall();
            iproduct.Create(p);
        }
        private static void SaleCreate(ISale isale)
        {
            Sale s = SaleAskall();
            isale.Create(s);
        }
        private static void CustomerCreate(ICustomer icustomer)
        {
            Customer c = CustomerAskall();
            icustomer.Create(c);
        }

        //Read
        private static void Read<T>(ICrud<T> crud)
        {
            Console.WriteLine("Insert id");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid id");
                return;
            }
            Console.WriteLine(crud.Read(id));
        }
       
        //Delete
        private static void Delete<T>(ICrud<T> crud)
        {
            Console.WriteLine("Insert id");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid id");
                return;
            }
            crud.Delete(id);
        }

        //ReadAll
        private static void ReadAll<T>(ICrud<T> crud)
        {
            List<T> list = crud.ReadAll();

            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        //Update
        private static void ProductUpdate(IProduct iproduct)
        {
            Product p = ProductAskall();
            iproduct.Update(p);
        }
        private static void SaleUpdate(ISale isale)
        {
            Sale s = SaleAskall();
            isale.Update(s);
        }
        private static void CustomerUpdate(ICustomer icustomer)
        {
            Customer c = CustomerAskall();
            icustomer.Update(c);
        }
        //Askall
        private static Product ProductAskall(int id=0)
        {
            int Amount;
            string name;
            category categ;
            double Price;

            //Console.WriteLine("insert id of product");
            //if (!int.TryParse(Console.ReadLine(), out id)) id = 1111;

            Console.WriteLine("enter name of product");
            name = Console.ReadLine()!;

            Console.WriteLine("enter Price of product");
            if (!double.TryParse(Console.ReadLine(), out Price)) Price = 10.0;

            Console.WriteLine("enter Amount of product");
            if (!int.TryParse(Console.ReadLine(), out Amount)) Amount = 1;

            Console.WriteLine("choose Category of product between 1-4");
            int cat;
            if (!int.TryParse(Console.ReadLine(), out cat))
                categ = 0;
            else
                categ = (category)cat;

            Product p = new Product(id, name, categ, Price, Amount);
            return p;
        }
        private static Sale SaleAskall(int id = 0)
        {
            int IdP, MinAmount;
            double AllPrice;
            bool IfEveryone;

            Console.WriteLine("enter IdP of sale");
            if (!int.TryParse(Console.ReadLine(), out IdP)) IdP = 1111;

            Console.WriteLine("enter the amount you want");
            if (!int.TryParse(Console.ReadLine(), out MinAmount)) MinAmount = 1;

            Console.WriteLine("Insert the price after discount");
            if (!double.TryParse(Console.ReadLine(), out AllPrice))
                AllPrice = 3;

            Console.WriteLine("Do you have to be a club customer?");
            if (!bool.TryParse(Console.ReadLine(), out IfEveryone))
                IfEveryone = true;

            //??? לבדוק לגבי אתחול התאריכים
            Sale s = new Sale(id, IdP, MinAmount, AllPrice, IfEveryone, DateTime.Now, DateTime.Now.AddDays(15));
            return s;
        }



        private static Customer CustomerAskall()
        {
            string Name, Address, Phone;
            int id;
            Console.WriteLine("insert custumer's id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = 0;

            Console.WriteLine("Insert customer's name");
            Name = Console.ReadLine()!;

            Console.WriteLine("Insert customer's address");
            Address = Console.ReadLine()!;

            Console.WriteLine("Insert customer's phone");
            Phone = Console.ReadLine()!;
            return new Customer(id, Name, Address, Phone);
        }
    }
}

