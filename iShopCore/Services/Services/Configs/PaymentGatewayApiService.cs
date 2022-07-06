using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class PaymentGatewayApiService : IPaymentGatewayApiService
    {
        private readonly IPaymentGatewayApiRepository _paymentGatewayApiRepository;
        private readonly IMapper _mapper;

        public PaymentGatewayApiService(IPaymentGatewayApiRepository paymentGatewayApiRepository, IMapper mapper)

        {
            _paymentGatewayApiRepository = paymentGatewayApiRepository;
            _mapper = mapper;
        }

        public Task<PaymentGatewayAPI> AddAsync(PaymentGatewayAPIDto paymentGatewayAPIDto)
        {
            var productSpec = _mapper.Map<PaymentGatewayAPI>(paymentGatewayAPIDto);
            return _paymentGatewayApiRepository.AddAsync(productSpec) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _paymentGatewayApiRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<PaymentGatewayAPI>> GetAllAsync()
        {
            return _paymentGatewayApiRepository.GetAllAsync();
        }

        public Task<PaymentGatewayAPI> GetAsync(long id)
        {
            return _paymentGatewayApiRepository.GetAsync(id);
        }

        public Task<PaymentGatewayAPI> UpdateAsync(PaymentGatewayAPIDto paymentGatewayAPIDto)
        {
            var productSpec = _mapper.Map<PaymentGatewayAPI>(paymentGatewayAPIDto);
            return _paymentGatewayApiRepository.UpdateAsync(productSpec);
        }
    }
}
