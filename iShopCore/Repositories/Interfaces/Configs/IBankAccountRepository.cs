using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IBankAccountRepository
    {
        Task<IEnumerable<BankAccount>> GetAllAsync();
        Task<BankAccount> GetAsync(long id);
        Task<BankAccount> AddAsync(BankAccount model);
        Task<BankAccount> UpdateAsync(BankAccount model);
        Task<long> DeleteAsync(long id);
    }
}
