namespace Commerce.Models.Pagination
{
    public interface IPagedRepo
    {
        Task<PagedList<Product>> GetProducts(ProductParameters productParameters,List<string> categoryName);
    }
}
