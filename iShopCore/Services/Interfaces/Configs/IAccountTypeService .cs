using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IAccountTypeService
    {
        Task<IEnumerable<AccountType>> GetAllAsync();
        Task<AccountType> GetAsync(long id);
        Task<AccountType> AddAsync(AccountTypeDto accountTypeDto);
        Task<AccountType> UpdateAsync(AccountTypeDto accountTypeDto);
        Task<long> DeleteAsync(long id);


    }
}
