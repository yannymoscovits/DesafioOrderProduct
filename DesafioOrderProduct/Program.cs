using System;
using DesafioOrderProduct.Entities;

namespace DesafioOrderProduct
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write(" Birthday Date: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client c1 = new Client(name, email, data);
            Order order = new Order(status);


            Console.Write("How many items to this order? ");
            int quant = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Enter #" + i + " item data :");
                Console.Write("Product Name :");
                string pname = Console.ReadLine();
                Console.Write("Price :");
                double pprice = double.Parse(Console.ReadLine());
                Console.Write("Quantity :");
                int quanty = int.Parse(Console.ReadLine());
                OrderItem product = new OrderItem(pname,pprice,quanty);
                order.AddItem(product);
                
            }
        
        }   
    }
}