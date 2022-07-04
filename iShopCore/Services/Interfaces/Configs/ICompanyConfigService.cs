using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface ICompanyConfigService
    {
        Task<IEnumerable<Company>> GetAllAsync();
        Task<Company> GetAsync(long id);
        Task<Company> AddAsync(CompanyConfigsDto companyConfigsDto);
        Task<Company> UpdateAsync(CompanyConfigsDto companyConfigsDto);
        Task<long> DeleteAsync(long id);


    }
}
