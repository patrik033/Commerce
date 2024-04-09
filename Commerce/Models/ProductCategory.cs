namespace Commerce.Models
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string ProductCategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
