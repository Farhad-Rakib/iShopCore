using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces.Configs;
using iShopCore.Services.Interfaces.Configs;

namespace iShopCore.Services.Services.Configs
{
   
    public class CompanyService:ICompanyService
    {
        private readonly ICompanyRepository _companyRepo;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepo,IMapper mapper)
        {
            _companyRepo = companyRepo;
            _mapper = mapper;
        }

        public Task<Company> AddAsync(CompanyDto companyDto)
        {
            var company = _mapper.Map<Company>(companyDto);
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

        public Task<Company> UpdateAsync(CompanyDto companyConfigsDto)
        {
            var company = _mapper.Map<Company>(companyConfigsDto);
            return _companyRepo.UpdateAsync(company);
        }
    }
}
