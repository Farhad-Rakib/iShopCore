using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IAccountTypeRepository _accountTypeRepository;
        private readonly IMapper _mapper;

        public AccountTypeService(IAccountTypeRepository accountTypeRepository, IMapper mapper)

        {
            _accountTypeRepository = accountTypeRepository;
            _mapper = mapper;
        }

        public Task<AccountType> AddAsync(AccountTypeDto accountTypeDto)
        {
            var accountType = _mapper.Map<AccountType>(accountTypeDto);
            return _accountTypeRepository.AddAsync(accountType) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _accountTypeRepository.DeleteAsync(id) ;
        }

        public Task<IEnumerable<AccountType>> GetAllAsync()
        {
            return _accountTypeRepository.GetAllAsync();
        }

        public Task<AccountType> GetAsync(long id)
        {
            return _accountTypeRepository.GetAsync(id);
        }

        public Task<AccountType> UpdateAsync(AccountTypeDto bankAccountDto)
        {
            var accountType = _mapper.Map<AccountType>(bankAccountDto);
            return _accountTypeRepository.UpdateAsync(accountType);
        }
    }
}
