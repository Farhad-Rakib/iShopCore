using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface ICompanyConfigsRepository
    {
        Task<IEnumerable<Company>> GetAllAsync();
        Task<Company> GetAsync(long id);
        Task<Company> AddAsync(Company company);
        Task<Company> UpdateAsync(Company model);
        Task<long> DeleteAsync(long id);
    }
}
