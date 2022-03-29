using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOrderProduct.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(double price)
        {
            
            Price = price;
        }

        public OrderItem(string name, double price, int quantity )
        {
            Quantity = quantity;
            Product.Name = name;
            Product.Price = price;
        }

       

        public double subTotal()
        {
            return
        }
    }
}
