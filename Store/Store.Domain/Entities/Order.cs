using System;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Enums;

namespace Store.Domain.Entities
{
    public class Order
    {
        private IList<OrderItem> _orderItems;

        public Order(IEnumerable<OrderItem> orderItems, int userId)
        {
            Date = DateTime.Now;
            OrderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(p => AddItem(p));
            UserId = userId;
            Status = EOrderStatus.Created;
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public IEnumerable<OrderItem> OrderItems { get => _orderItems; private set => _orderItems = new List<OrderItem>(value); }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public decimal Total { get { return _orderItems.Sum(item => (item.Price * item.Quantity)); } }
        public EOrderStatus Status { get; private set; }

        public void AddItem(OrderItem item)
        {
            
        }
    }
}