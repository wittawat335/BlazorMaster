using BlazorMaster.Server.Models;
using BlazorMaster.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMaster.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DbBlazorMasterContext _dbContext;

        public ProductController(DbBlazorMasterContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = new List<ProductDTO>();
            foreach (var item in await _dbContext.Products.ToListAsync())
            {
                list.Add(new ProductDTO
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                });
            }

            return Ok(list);
        }
    }
}
