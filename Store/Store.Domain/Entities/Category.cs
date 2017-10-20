using System.Collections.Generic;

namespace Store.Domain.Entities
{

    public class Category
    {
        public Category(string title)
        {

            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        public ICollection<Product> Products { get; private set; }
    }
}
