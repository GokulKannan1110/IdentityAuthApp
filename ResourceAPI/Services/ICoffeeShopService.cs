using ResourceAPI.Models;

namespace ResourceAPI.Services
{
    public interface ICoffeeShopService
    {
        Task<List<CoffeeShopModel>> List();
    }
}
