using BlazorMaster.Shared;

namespace BlazorMaster.Client.Services
{
    public interface ISaleService
    {
        Task<bool> Get(SaleDTO saleDTO);
    }
}
