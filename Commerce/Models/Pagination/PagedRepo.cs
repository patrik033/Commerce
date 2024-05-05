
using Commerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Models.Pagination
{
    public class PagedRepo : IPagedRepo
    {
        private readonly AppDbContext _context;

        public PagedRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedList<Product>> GetProducts(ProductParameters parameters, List<string> categoryName)
        {

            var listItems = new List<Product>();

            if (categoryName.Count > 0)
            {
                foreach (var product in categoryName)
                {
                    var items = await _context.ProductCategories
                        .Include(x => x.Products)
                        .Where(x => x.ProductCategoryName.ToUpper() == product.ToUpper())
                        .SelectMany(x => x.Products)
                        .OrderBy(x => x.Name)
                        .AsNoTracking()
                        .ToListAsync();
                    listItems.AddRange(items);
                }
            }
            else
            {
          
                    var items = await _context.ProductCategories
                        .Include(x => x.Products)
                        .SelectMany(x => x.Products)
                        .OrderBy(x => x.Name)
                        .AsNoTracking()
                        .ToListAsync();
                    listItems.AddRange(items);
                
            }

            return PagedList<Product>
                .ToPagedList(listItems, parameters.PageNumber, parameters.PageSize);
        }
    }
}
