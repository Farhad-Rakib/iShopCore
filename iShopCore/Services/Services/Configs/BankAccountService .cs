using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly IMapper _mapper;

        public BankAccountService(IBankAccountRepository bankAccountRepository, IMapper mapper)

        {
            _bankAccountRepository = bankAccountRepository;
            _mapper = mapper;
        }

        public Task<BankAccount> AddAsync(BankAccountDto bankAccountDto)
        {
            var bankAccount = _mapper.Map<BankAccount>(bankAccountDto);
            return _bankAccountRepository.AddAsync(bankAccount) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _bankAccountRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<BankAccount>> GetAllAsync()
        {
            return _bankAccountRepository.GetAllAsync();
        }

        public Task<BankAccount> GetAsync(long id)
        {
            return _bankAccountRepository.GetAsync(id);
        }

        public Task<BankAccount> UpdateAsync(BankAccountDto bankAccountDto)
        {
            var bankAccount = _mapper.Map<BankAccount>(bankAccountDto);
            return _bankAccountRepository.UpdateAsync(bankAccount);
        }
    }
}
