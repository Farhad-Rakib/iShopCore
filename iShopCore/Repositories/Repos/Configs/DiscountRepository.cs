using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs
{
    public class DiscountRepository : IDiscountRepository
    {
        private IBaseRepository<Discount> _baseRepository;

        public DiscountRepository(IBaseRepository<Discount> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Discount> AddAsync(Discount obj)
        {
            _baseRepository.Insert(obj);
            _baseRepository.Save();
            return obj;
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

        public async Task<IEnumerable<Discount>> GetAllAsync()
        {
            var discounts = await _baseRepository.GetAll();
            return discounts.ToList();

        }

        public async Task<Discount> GetAsync(long id)
        {
            var data =  await _baseRepository.GetById(id);
            if (data == null)
                throw new ArgumentException("Discount is not exist");
            return data;
        }

        public async Task<Discount> UpdateAsync(Discount model)
        {
            var existing = await _baseRepository.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
            if (existing == null)
                throw new ArgumentException("Company is not exist");

            existing.Id = model.Id;
            existing.UpdatedDate = model.UpdatedDate;
            existing.UpdatedBy = model.UpdatedBy;
            existing.DiscountRate = model.DiscountRate;
            existing.DiscountType = model.DiscountType;
            

           _baseRepository.Update(existing);
            return existing;

        }
    }
}
