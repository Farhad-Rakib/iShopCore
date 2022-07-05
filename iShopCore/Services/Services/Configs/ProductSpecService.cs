using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class ProductSpecService : IProductSpecService
    {
        private readonly IProductSpecRepository _productSpecRepository;
        private readonly IMapper _mapper;

        public ProductSpecService(IProductSpecRepository productSpecRepository,IMapper mapper)
        {
            _productSpecRepository = productSpecRepository;
            _mapper = mapper;
        }

        public Task<ProductSpec> AddAsync(ProductSpecDto productSpecDto)
        {
            var productSpec = _mapper.Map<ProductSpec>(productSpecDto);
            return _productSpecRepository.AddAsync(productSpec) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _productSpecRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<ProductSpec>> GetAllAsync()
        {
            return _productSpecRepository.GetAllAsync();
        }

        public Task<ProductSpec> GetAsync(long id)
        {
            return _productSpecRepository.GetAsync(id);
        }

        public Task<ProductSpec> UpdateAsync(ProductSpecDto productSpecDto)
        {
            var productSpec = _mapper.Map<ProductSpec>(productSpecDto);
            return _productSpecRepository.UpdateAsync(productSpec);
        }
    }
}
