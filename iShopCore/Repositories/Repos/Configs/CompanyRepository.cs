using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs
{
    public class CompanyRepository : ICompanyRepository
    {
        private IBaseRepository<Company> _baseRepository;

        public CompanyRepository(IBaseRepository<Company> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Company> AddAsync(Company company)
        {
            _baseRepository.Insert(company);
            _baseRepository.Save();
            return company;
        }



        public async Task<long> DeleteAsync(long id)
        {
            var existing = await _baseRepository.GetById(id);

            if (existing != null)
            {
                _baseRepository.Delete(id);
                _baseRepository.Save();
                return id;
            }
            else {
                throw new ArgumentException("Company is not exist");
            }
                
            
            
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            var companyConfig = await _baseRepository.GetAll();
            return companyConfig.ToList();

        }

        public async Task<Company> GetAsync(long id)
        {
            var data =  await _baseRepository.GetById(id);
            if (data == null)
                throw new ArgumentException("Company is not exist");
            return data;
        }

        public async Task<Company> UpdateAsync(Company company)
        {
            var existing = await _baseRepository.FindBy(c => c.Id == company.Id).FirstOrDefaultAsync();
            if (existing == null)
                throw new ArgumentException("Company is not exist");

            existing.Id = company.Id;
            existing.UpdatedDate = company.UpdatedDate;
            existing.UpdatedBy = company.UpdatedBy;
            existing.Logo = company.Logo;
            existing.Name = company.Name;
            existing.Location = company.Location;
            existing.OwnersName = company.OwnersName;
            existing.MobileNo = company.MobileNo;
            existing.CompanyType = company.CompanyType;

           _baseRepository.Update(existing);
            return existing;

        }
    }
}
