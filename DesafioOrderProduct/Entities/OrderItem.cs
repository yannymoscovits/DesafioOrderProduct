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

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2")
                + ", Quantity :" + Quantity + ", Subtotal : $" +
                subTotal();
        }
    }
}
