using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<Discount>> GetAllAsync();
        Task<Discount> GetAsync(long id);
        Task<Discount> AddAsync(Discount model);
        Task<Discount> UpdateAsync(Discount model);
        Task<long> DeleteAsync(long id);
    }
}
