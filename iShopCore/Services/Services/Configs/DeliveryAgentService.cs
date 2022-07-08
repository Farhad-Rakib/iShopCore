using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class DeliveryAgentService : IDeliveryAgentService
    {
        private readonly IDeliveryAgentRepository _deliveryAgentRepository;
        private readonly IMapper _mapper;

        public DeliveryAgentService(IDeliveryAgentRepository deliveryAgentRepository, IMapper mapper)

        {
            _deliveryAgentRepository = deliveryAgentRepository;
            _mapper = mapper;
        }

        public Task<DeliveryAgent> AddAsync(DeliveryAgentDto deliveryAgentDto)
        {
            var bankAccount = _mapper.Map<DeliveryAgent>(deliveryAgentDto);
            return _deliveryAgentRepository.AddAsync(bankAccount) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _deliveryAgentRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<DeliveryAgent>> GetAllAsync()
        {
            return _deliveryAgentRepository.GetAllAsync();
        }

        public Task<DeliveryAgent> GetAsync(long id)
        {
            return _deliveryAgentRepository.GetAsync(id);
        }

        public Task<DeliveryAgent> UpdateAsync(DeliveryAgentDto deliveryAgentDto)
        {
            var bankAccount = _mapper.Map<DeliveryAgent>(deliveryAgentDto);
            return _deliveryAgentRepository.UpdateAsync(bankAccount);
        }
    }
}
