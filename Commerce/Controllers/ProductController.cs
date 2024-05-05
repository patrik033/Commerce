using Commerce.Data;
using Commerce.Models.Pagination;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Commerce.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IPagedRepo _pagedRepo;

        public ProductController(AppDbContext context,IPagedRepo pagedRepo)
        {
            _context = context;
            _pagedRepo = pagedRepo;
        }

        [HttpGet("Featured")]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            var featuredProduct = await _context.Products
                .Where(x => x.IsFeatured)
                .Take(10)
                .ToListAsync();

            if (featuredProduct != null)
            {
                return Ok(featuredProduct);
            }
            return BadRequest();
        }


        [HttpGet("DrinksPaged")]
        public async Task<IActionResult> GetPagedDrinks([FromQuery] ProductParameters productParameters,[FromQuery] List<string> ? categoryName)
        {
            var products = await _pagedRepo.GetProducts(productParameters,categoryName);

            Response.Headers.Append("X-Pagination", JsonConvert.SerializeObject(products.MetaData));

            return Ok(products);
        }


        [HttpGet("Drinks/{id}")]
        public async Task<IActionResult> GetSingleProduct(Guid id)
        {
            var getProductById = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (getProductById == null)
            {
                return NotFound();
            }
            return Ok(getProductById);
        }

        [HttpGet("DrinksNames/{id}")]
        public async Task<IActionResult> GetSingleProductName(string id)
        {
            var getProductById = await _context.Products.FirstOrDefaultAsync(p => p.Name.ToUpper() == id.ToUpper());
            if (getProductById == null)
            {
                return NotFound();
            }
            return Ok(getProductById);
        }
    }
}
