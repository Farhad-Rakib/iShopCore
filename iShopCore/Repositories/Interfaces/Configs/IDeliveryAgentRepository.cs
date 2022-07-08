using iShopCore.Entities.config;

namespace iShopCore.Repositories.Interfaces.Configs
{
    public interface IDeliveryAgentRepository
    {
        Task<IEnumerable<DeliveryAgent>> GetAllAsync();
        Task<DeliveryAgent> GetAsync(long id);
        Task<DeliveryAgent> AddAsync(DeliveryAgent model);
        Task<DeliveryAgent> UpdateAsync(DeliveryAgent model);
        Task<long> DeleteAsync(long id);
    }
}
