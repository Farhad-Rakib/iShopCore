using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IPaymentGatewayApiRepository
    {
        Task<IEnumerable<PaymentGatewayAPI>> GetAllAsync();
        Task<PaymentGatewayAPI> GetAsync(long id);
        Task<PaymentGatewayAPI> AddAsync(PaymentGatewayAPI model);
        Task<PaymentGatewayAPI> UpdateAsync(PaymentGatewayAPI model);
        Task<long> DeleteAsync(long id);
    }
}
