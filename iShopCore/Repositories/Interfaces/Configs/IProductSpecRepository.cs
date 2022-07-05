using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IProductSpecRepository
    {
        Task<IEnumerable<ProductSpec>> GetAllAsync();
        Task<ProductSpec> GetAsync(long id);
        Task<ProductSpec> AddAsync(ProductSpec company);
        Task<ProductSpec> UpdateAsync(ProductSpec model);
        Task<long> DeleteAsync(long id);
    }
}
