using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IDiscountService
    {
        Task<IEnumerable<Discount>> GetAllAsync();
        Task<Discount> GetAsync(long id);
        Task<Discount> AddAsync(DiscountDto dto);
        Task<Discount> UpdateAsync(DiscountDto dto);
        Task<long> DeleteAsync(long id);


    }
}
