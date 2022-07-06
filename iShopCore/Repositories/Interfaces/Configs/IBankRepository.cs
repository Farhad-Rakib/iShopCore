using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IBankRepository
    {
        Task<IEnumerable<Bank>> GetAllAsync();
        Task<Bank> GetAsync(long id);
        Task<Bank> AddAsync(Bank model);
        Task<Bank> UpdateAsync(Bank model);
        Task<long> DeleteAsync(long id);
    }
}
