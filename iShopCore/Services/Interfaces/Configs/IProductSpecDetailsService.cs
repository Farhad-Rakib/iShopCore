using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IProductSpecDeatilsService
    {
        Task<IEnumerable<ProductSpecDetails>> GetAllAsync();
        Task<ProductSpecDetails> GetAsync(long id);
        Task<ProductSpecDetails> AddAsync(ProductSpecDetailsDto companyConfigsDto);
        Task<ProductSpecDetails> UpdateAsync(ProductSpecDetailsDto companyConfigsDto);
        Task<long> DeleteAsync(long id);


    }
}
