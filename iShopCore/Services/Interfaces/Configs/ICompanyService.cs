using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAllAsync();
        Task<Company> GetAsync(long id);
        Task<Company> AddAsync(CompanyDto companyConfigsDto);
        Task<Company> UpdateAsync(CompanyDto companyConfigsDto);
        Task<long> DeleteAsync(long id);


    }
}
