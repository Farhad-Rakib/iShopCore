using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IProductSpecService
    {
        Task<IEnumerable<ProductSpec>> GetAllAsync();
        Task<ProductSpec> GetAsync(long id);
        Task<ProductSpec> AddAsync(ProductSpecDto companyConfigsDto);
        Task<ProductSpec> UpdateAsync(ProductSpecDto companyConfigsDto);
        Task<long> DeleteAsync(long id);


    }
}
