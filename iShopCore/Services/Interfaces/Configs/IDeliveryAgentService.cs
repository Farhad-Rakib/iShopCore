using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;

namespace iShopCore.Services.Interfaces.Configs
{
   

    public interface IDeliveryAgentService
    {
        Task<IEnumerable<DeliveryAgent>> GetAllAsync();
        Task<DeliveryAgent> GetAsync(long id);
        Task<DeliveryAgent> AddAsync(DeliveryAgentDto deliveryAgentDto);
        Task<DeliveryAgent> UpdateAsync(DeliveryAgentDto deliveryAgentDto);
        Task<long> DeleteAsync(long id);


    }
}
