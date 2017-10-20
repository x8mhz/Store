using System;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class Order
    {
        #region Ctor And Props

        public Order(DateTime orderDate, int userId, User user)
        {
            Id = Guid.NewGuid();
            OrderDate = orderDate;
            UserId = userId;
        }

        public Guid Id { get; private set; }
        public int UserId { get; private set; }
        public DateTime OrderDate { get; private set; }

        #endregion

        //Relações com o banco de dados.
        #region Relationship

        public virtual User User { get; set; }
        public ICollection<OrderProduct> OrderItems { get; set; }

        #endregion



    }
}