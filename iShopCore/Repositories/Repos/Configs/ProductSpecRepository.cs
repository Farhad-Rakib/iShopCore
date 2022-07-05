using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs
{
    public class ProductSpecRepository : IProductSpecRepository
    {
        private IBaseRepository<ProductSpec> _baseRepository;

        public ProductSpecRepository(IBaseRepository<ProductSpec> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<ProductSpec> AddAsync(ProductSpec productSpec)
        {
            _baseRepository.Insert(productSpec);
            _baseRepository.Save();
            return productSpec;
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

        public async Task<IEnumerable<ProductSpec>> GetAllAsync()
        {
            var productSpecs = await _baseRepository.GetAll();
            return productSpecs.ToList();

        }

        public async Task<ProductSpec> GetAsync(long id)
        {
            var data =  await _baseRepository.GetById(id);
            if (data == null)
                throw new ArgumentException("Company is not exist");
            return data;
        }

        public async Task<ProductSpec> UpdateAsync(ProductSpec productSpec)
        {
            var existing = await _baseRepository.FindBy(c => c.Id == productSpec.Id).FirstOrDefaultAsync();
            if (existing == null)
                throw new ArgumentException("Company is not exist");

            existing.Id = productSpec.Id;
            existing.UpdatedDate = productSpec.UpdatedDate;
            existing.UpdatedBy = productSpec.UpdatedBy;
            existing.Name = productSpec.Name;
            

           _baseRepository.Update(existing);
            return existing;

        }
    }
}
