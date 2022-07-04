using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class CompanyConfigService:ICompanyConfigService
    {
        private readonly ICompanyConfigsRepository _companyRepo;
        private readonly IMapper _mapper;

        public CompanyConfigService(ICompanyConfigsRepository companyRepo,IMapper mapper)
        {
            _companyRepo = companyRepo;
            _mapper = mapper;
        }

        public Task<Company> AddAsync(CompanyConfigsDto companyConfigsDto)
        {
            var company = _mapper.Map<Company>(companyConfigsDto);
            return _companyRepo.AddAsync(company) ;
        }

        public Task <long> DeleteAsync(long id)
        {
            return _companyRepo.DeleteAsync(id) ;
        }

        public Task<IEnumerable<Company>> GetAllAsync()
        {
            return _companyRepo.GetAllAsync();
        }

        public Task<Company> GetAsync(long id)
        {
            return _companyRepo.GetAsync(id);
        }

        public Task<Company> UpdateAsync(CompanyConfigsDto companyConfigsDto)
        {
            return _companyRepo.UpdateAsync(_mapper.Map<Company>(companyConfigsDto));
        }
    }
}
