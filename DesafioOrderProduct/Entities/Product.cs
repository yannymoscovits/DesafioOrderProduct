using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOrderProduct.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public OrderItem OrderItem { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
           
        }
    }
}
