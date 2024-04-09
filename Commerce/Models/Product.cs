using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Commerce.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Precision(18, 2)]
        public bool IsFeatured { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public  string Brand { get; set; }
        public int Stock { get; set; }
        public bool IsForLegalAge { get; set; }
        public string Description { get; set; }
        public string ?ShortDescription { get; set; }
        public string ?ProductFacts { get; set; }
        public Guid ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
    }
}
