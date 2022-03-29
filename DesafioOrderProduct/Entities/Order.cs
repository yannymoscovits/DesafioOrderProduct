using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOrderProduct.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
         public OrderItem OrderItem  { get; set; }
        public  Client Client { get; set; }


        public Order(DateTime moment, OrderStatus status, OrderItem orderItem)
        {
            Moment = moment;
            Status = status;
            OrderItem = orderItem;
        }

        public Order(OrderStatus status)
        {
            Status = status;
        }

        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            return 
        }
    }
}
