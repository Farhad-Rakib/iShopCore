using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IPaymentGatewayApiService
    {
        Task<IEnumerable<PaymentGatewayAPI>> GetAllAsync();
        Task<PaymentGatewayAPI> GetAsync(long id);
        Task<PaymentGatewayAPI> AddAsync(PaymentGatewayAPIDto paymentGatewayAPIDto);
        Task<PaymentGatewayAPI> UpdateAsync(PaymentGatewayAPIDto paymentGatewayAPIDto);
        Task<long> DeleteAsync(long id);


    }
}
