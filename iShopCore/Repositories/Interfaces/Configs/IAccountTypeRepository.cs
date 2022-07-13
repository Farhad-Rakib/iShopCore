using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IAccountTypeRepository
    {
        Task<IEnumerable<AccountType>> GetAllAsync();
        Task<AccountType> GetAsync(long id);
        Task<AccountType> AddAsync(AccountType model);
        Task<AccountType> UpdateAsync(AccountType model);
        Task<long> DeleteAsync(long id);
    }
}
