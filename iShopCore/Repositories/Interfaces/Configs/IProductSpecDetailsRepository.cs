using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IProductSpecDetailsRepository
    {
        Task<IEnumerable<ProductSpecDetails>> GetAllAsync();
        Task<ProductSpecDetails> GetAsync(long id);
        Task<ProductSpecDetails> AddAsync(ProductSpecDetails company);
        Task<ProductSpecDetails> UpdateAsync(ProductSpecDetails model);
        Task<long> DeleteAsync(long id);
    }
}
