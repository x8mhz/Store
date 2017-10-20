using System;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class Order
    {
        public Order(DateTime orderDate, int userId, User user)
        {
            OrderDate = orderDate;
            UserId = userId;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public DateTime OrderDate { get; private set; }

        public virtual User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

    }
}