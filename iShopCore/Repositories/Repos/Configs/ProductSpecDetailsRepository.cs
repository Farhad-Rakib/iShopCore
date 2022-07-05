using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs
{
    public class ProductSpecDetailsRepository : IProductSpecDetailsRepository
    {
        private IBaseRepository<ProductSpecDetails> _baseRepository;

        public ProductSpecDetailsRepository(IBaseRepository<ProductSpecDetails> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<ProductSpecDetails> AddAsync(ProductSpecDetails productSpecDetails)
        {
            _baseRepository.Insert(productSpecDetails);
            _baseRepository.Save();
            return productSpecDetails;
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
                throw new ArgumentException("Product Spec Details is not exist");
            }
                
            
            
        }

        public async Task<IEnumerable<ProductSpecDetails>> GetAllAsync()
        {
            var productSpecs = await _baseRepository.GetAll();
            return productSpecs.ToList();

        }

        public async Task<ProductSpecDetails> GetAsync(long id)
        {
            var data =  await _baseRepository.GetById(id);
            if (data == null)
                throw new ArgumentException("Product Spec Details is not exist");
            return data;
        }

        public async Task<ProductSpecDetails> UpdateAsync(ProductSpecDetails model)
        {
            var existing = await _baseRepository.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
            if (existing == null)
                throw new ArgumentException("Company is not exist");

            existing.Id = model.Id;
            existing.UpdatedDate = model.UpdatedDate;
            existing.UpdatedBy = model.UpdatedBy;
            existing.Name = model.Name;
            existing.ProductSpecId = model.ProductSpecId;
            

           _baseRepository.Update(existing);
            return existing;

        }
    }
}
