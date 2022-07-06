using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IBankService
    {
        Task<IEnumerable<Bank>> GetAllAsync();
        Task<Bank> GetAsync(long id);
        Task<Bank> AddAsync(BankDto paymentGatewayAPIDto);
        Task<Bank> UpdateAsync(BankDto paymentGatewayAPIDto);
        Task<long> DeleteAsync(long id);


    }
}
