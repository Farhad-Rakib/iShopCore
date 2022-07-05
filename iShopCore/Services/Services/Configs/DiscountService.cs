using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _repo;
        private readonly IMapper _mapper;

        public DiscountService(IDiscountRepository repo,IMapper mapper)

        {
            _repo = repo;
            _mapper = mapper;
        }

        public Task<Discount> AddAsync(DiscountDto dto)
        {
            var productSpec = _mapper.Map<Discount>(dto);
            return _repo.AddAsync(productSpec) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _repo.DeleteAsync(id) ;
        }

        public Task<IEnumerable<Discount>> GetAllAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Discount> GetAsync(long id)
        {
            return _repo.GetAsync(id);
        }

        public Task<Discount> UpdateAsync(DiscountDto dto)
        {
            var productSpec = _mapper.Map<Discount>(dto);
            return _repo.UpdateAsync(productSpec);
        }
    }
}
