using BlazorMaster.Shared;

namespace BlazorMaster.Client.Services
{
    public interface IProductService
    {
        Task<List<ProductDTO>> List();
    }
}
