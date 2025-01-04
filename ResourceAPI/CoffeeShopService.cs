using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ResourceAPI.Models;
using ResourceAPI.Services;

namespace ResourceAPI
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext dbContext;
        public CoffeeShopService(ApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
        }

        public async Task<List<CoffeeShopModel>> List()
        {
            var coffeeShops = await (from shop in dbContext.CoffeeShops
                                     select new CoffeeShopModel()
                                     {
                                         Id = shop.Id,
                                         Name = shop.Name,
                                         Address = shop.Address,
                                         OpeningHours = shop.OpeningHours
                                     }).ToListAsync();

            return coffeeShops;
        }
    }
}
