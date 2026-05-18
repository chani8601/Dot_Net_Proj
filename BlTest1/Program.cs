using BIApi;
using BO;

namespace BlTest1
{
    internal class Program
    {
        static readonly IBI s_bl = Factory.Get();
        static void Main(string[] args)
        {
            //DalTest.Initialization.Initialize();
            bool club = true;
            Console.WriteLine(" Hello costumer");

            Console.WriteLine("insert id:");
            int customerId = int.Parse(Console.ReadLine());

            if (!s_bl.Customer.IsCustomerExist(customerId))
            {
                Console.WriteLine("Customer does not exist");
                club = false;
               
            }

            //Console.WriteLine("Are you a club member?");
            //Console.WriteLine("1 - Yes");
            //Console.WriteLine("0 - No");

            //bool club = Console.ReadLine() == "1";

            Order order = new Order()
            {
                club = club,
                products = new List<ProductInOrder>(),
                final_price = 0
            };

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== Order Menu =====");
                Console.WriteLine("1 - Add product to order");
                Console.WriteLine("2 - Display order");
                Console.WriteLine("3 - Final price");
                Console.WriteLine("4 - Place order");
                Console.WriteLine("0 - Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter product ID:");
                            int productId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter amount:");
                            int amount = int.Parse(Console.ReadLine());

                            List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, productId, amount);

                            Console.WriteLine("Product added to order");

                            if (sales != null && sales.Count > 0)
                            {
                                Console.WriteLine("Sales found:");

                                foreach (var sale in sales)
                                {
                                    Console.WriteLine($"Sale ID: {sale.id}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No sales for this product");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("===== Order =====");

                        if (order.products == null || order.products.Count == 0)
                        {
                            Console.WriteLine("No products in order");
                            break;
                        }

                        foreach (var item in order.products)
                        {
                            Console.WriteLine($"Product ID: {item.id}");
                            Console.WriteLine($"Name: {item.name}");
                            Console.WriteLine($"Amount: {item.amount}");
                            Console.WriteLine($"Price for a single product: {item.basic_price}");
                            Console.WriteLine($"Final price: {item.final_price}");

                            Console.WriteLine("Sales:");

                            if (item.sales != null)
                            {
                                foreach (var sale in item.sales)
                                {
                                    Console.WriteLine($"Sale ID: {sale.id}");
                                }
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Final order price: {order.final_price}");
                        break;

                    case 4:
                        try
                        {
                            s_bl.Order.DoOrder(order);
                            Console.WriteLine("Order placed successfully");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 0);

        }
    }
}
