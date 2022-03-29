﻿using System;
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
        public Product Product { get; set; }


        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
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
            double total = 0;
            foreach (OrderItem item in Items)
            {
                         
                total += item.subTotal();
                
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment : " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status :" + Status);
            sb.AppendLine("Client: " + Client.Name + " " + Client.BirthDate + " - " + Client.Email);
            sb.AppendLine("Order Items :");
                       

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            
            sb.Append("Total Price: $" + Total());
            return sb.ToString();
              
        }
    }
}
