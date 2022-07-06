using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;
        private readonly IMapper _mapper;

        public BankService(IBankRepository bankRepository, IMapper mapper)

        {
            _bankRepository = bankRepository;
            _mapper = mapper;
        }

        public Task<Bank> AddAsync(BankDto bankDto)
        {
            var bank = _mapper.Map<Bank>(bankDto);
            return _bankRepository.AddAsync(bank) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _bankRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<Bank>> GetAllAsync()
        {
            return _bankRepository.GetAllAsync();
        }

        public Task<Bank> GetAsync(long id)
        {
            return _bankRepository.GetAsync(id);
        }

        public Task<Bank> UpdateAsync(BankDto bankDto)
        {
            var bank = _mapper.Map<Bank>(bankDto);
            return _bankRepository.UpdateAsync(bank);
        }
    }
}
