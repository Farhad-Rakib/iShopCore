using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class ProductSpecDetailsService : IProductSpecDeatilsService
    {
        private readonly IProductSpecDetailsRepository _productSpecDetailsRepository;
        private readonly IMapper _mapper;

        public ProductSpecDetailsService(IProductSpecDetailsRepository productSpecDetailsRepository,IMapper mapper)

        {
            _productSpecDetailsRepository = productSpecDetailsRepository;
            _mapper = mapper;
        }

        public Task<ProductSpecDetails> AddAsync(ProductSpecDetailsDto productSpecDetailsDto)
        {
            var productSpec = _mapper.Map<ProductSpecDetails>(productSpecDetailsDto);
            return _productSpecDetailsRepository.AddAsync(productSpec) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _productSpecDetailsRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<ProductSpecDetails>> GetAllAsync()
        {
            return _productSpecDetailsRepository.GetAllAsync();
        }

        public Task<ProductSpecDetails> GetAsync(long id)
        {
            return _productSpecDetailsRepository.GetAsync(id);
        }

        public Task<ProductSpecDetails> UpdateAsync(ProductSpecDetailsDto productSpecDetailsDto)
        {
            var productSpec = _mapper.Map<ProductSpecDetails>(productSpecDetailsDto);
            return _productSpecDetailsRepository.UpdateAsync(productSpec);
        }
    }
}
