using BlazorMaster.Server.Models;
using BlazorMaster.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMaster.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly DbBlazorMasterContext _dbContext;

        public SaleController(DbBlazorMasterContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SaleDTO saleDTO)
        {
            try
            {
                var saleModel = new Sale();
                var saleDetailModel = new List<SaleDetail>();

                saleModel.Customer = saleDTO.Customer;
                saleModel.Total = saleDTO.Total;

                foreach (var item in saleDTO.saleDetails)
                {
                    saleDetailModel.Add(new SaleDetail
                    {
                        ProductId = item.Product.ProductId,
                        Amount = item.Amount,
                        SubTotal = item.SubTotal
                    });
                }

                saleModel.SaleDetails = saleDetailModel;
                _dbContext.Sales.Add(saleModel);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex) {
               return BadRequest(ex);
            }
        }
    }
}
