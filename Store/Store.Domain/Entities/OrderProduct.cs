using System;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class OrderProduct
    {
        #region Ctor And Props  

        public OrderProduct(int productId, int quantity, decimal unitPrice)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = Quantity * UnitPrice;
        }
        
        public Guid Id { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }

        #endregion

        //Relações com o banco de dados
        #region Relationship

        public virtual Order Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        #endregion
    }
}