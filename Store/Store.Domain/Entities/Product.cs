using System;

namespace Store.Domain.Entities
{
    public class Product
    {
        #region Ctor And Props

        public Product(string title, string description, decimal price, int quantityOnHand, Category category)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Price = price;
            QuantityOnHand = quantityOnHand;
            Category = category;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Category Category { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }


        #endregion

        //Relações com o banco de dados
        #region Relationship

        public virtual OrderProduct OrderItem { get; set; }
        
        #endregion
    }
}