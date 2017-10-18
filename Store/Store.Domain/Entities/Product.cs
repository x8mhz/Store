namespace Store.Domain.Entities
{
    public class Product
    {

        public Product(string title, string description, decimal price, int quantityOnHand, int categoryId)
        {
            Title = title;
            Description = description;
            Price = price;
            QuantityOnHand = quantityOnHand;
            CategoryId = categoryId;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public int CategoryId { get; private set; }

        public virtual Category Category { get; private set; }
    }
}