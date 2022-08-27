using Product;
using System;
using System.Collections.Generic;
using System.Text;
using Product;
using Customer;
using Order;

namespace Ecomerce
{
    public class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press 1 for to enter the Product data ");
            Console.WriteLine("press 2 for to enter the customer data ");
            Console.WriteLine("press 3 for to enter the order details ");

            int Success = int.Parse(Console.ReadLine());

            switch (Success)
            {
              case 1:
                     IProduct product1 = new Products();
                     Products product = new Products();
                     Console.WriteLine("Enter the brand_Name:");
                     product.MainApp_Name = Console.ReadLine();
                     product.MainPage();
                     Console.WriteLine("Enter the Product Details:");
                    Console.WriteLine("Enter the ProductId:");
                    product.ProductId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Product Name:");
                    product.ProductName= Console.ReadLine();
                    Console.WriteLine("Enter the Product Price:");
                    product.ProductPrice= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Product Quality:");
                    product.Quality = Console.ReadLine();
                     product.ShowProducts();
                     Console.WriteLine("Enter the Price:");
                     product1.GetProductPrice();
              break;
             case 2:
                    ICustomer customer = new Customers();
                    Customers customer1= new Customers();
                    Console.WriteLine("Enter the brand_Name:");
                    customer1.MainApp_Name = Console.ReadLine();
                    customer1.MainPage();
                    Console.WriteLine("Enter the Customer Details:");
                    Console.WriteLine("Enter the CustomerId:");
                    customer1.CustId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Customer Name:");
                    customer1.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Customer Age:");
                    customer1.CustAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Customer Email:");
                    customer1.Email = Console.ReadLine();
                    Console.WriteLine("Enter the PhoneNo:");
                    customer1.PhoneNo = int.Parse(Console.ReadLine());
                    customer1.ShowCustomer();
                    Console.WriteLine("Get Price:");
                    customer.GetCustomer();
               break;
                case 3:
                    IOrder order = new Orders();
                    Orders orders = new Orders();
                    Console.WriteLine("Enter the brand_Name:");
                    orders.MainApp_Name = Console.ReadLine();
                    orders.MainPage();
                    Console.WriteLine("Enter the Order details:");
                    Console.WriteLine("Enter the Order Id:");
                    orders.OrderId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the OrderDate:");
                    orders.OrderDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter the OrderItems:");
                    orders.OrderItems = Console.ReadLine();
                    Console.WriteLine("Enter the OrderLocaion:");
                    orders.OrderLocation = Console.ReadLine();
                    orders.ShowOrders();
                    Console.WriteLine("GET  OrderItems:");
                    order.GetOrders();
               break;
                default:
                    Console.WriteLine("No Data Available");
                    break;
            }
        
        }
        
    }
    
}
