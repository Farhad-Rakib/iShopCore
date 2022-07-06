using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IBankAccountService
    {
        Task<IEnumerable<BankAccount>> GetAllAsync();
        Task<BankAccount> GetAsync(long id);
        Task<BankAccount> AddAsync(BankAccountDto bankAccountDto);
        Task<BankAccount> UpdateAsync(BankAccountDto bankAccountDto);
        Task<long> DeleteAsync(long id);


    }
}
