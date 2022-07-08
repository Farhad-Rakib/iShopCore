using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs;

public class DeliveryAgentRepository : IDeliveryAgentRepository

{
    private IBaseRepository<DeliveryAgent> _deliveyAgentRepo;

    public DeliveryAgentRepository(IBaseRepository<DeliveryAgent> deliveryAgentRepo)
    {
        _deliveyAgentRepo = deliveryAgentRepo;
    }

    public async Task<DeliveryAgent> AddAsync(DeliveryAgent model)
    {
        _deliveyAgentRepo.Insert(model);
        _deliveyAgentRepo.Save();
        return model;
    }

    public async Task<long> DeleteAsync(long id)
    {
        var existing = await _deliveyAgentRepo.GetById(id);

        if (existing != null)
        {
            _deliveyAgentRepo.Delete(id);
            _deliveyAgentRepo.Save();
            return id;
        }
        else
        {
            throw new ArgumentException("Delivery Agent is not exist");
        }
    }

    public async Task<IEnumerable<DeliveryAgent>> GetAllAsync()
    {
        var data = await _deliveyAgentRepo.GetAll();
        return data.ToList();

    }

    public async Task<DeliveryAgent> GetAsync(long id)
    {
        var data = await _deliveyAgentRepo.GetById(id);
        if (data == null)
            throw new ArgumentException("Delivery is not exist");
        return data;
    }

    public async Task<DeliveryAgent> UpdateAsync(DeliveryAgent model)
    {
        var existing = await _deliveyAgentRepo.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
        if (existing == null)
            throw new ArgumentException("Bank not exist");

        existing.Id = model.Id;
        existing.UpdatedDate = model.UpdatedDate;
        existing.UpdatedBy = model.UpdatedBy;
        existing.Name = model.Name;
        existing.DeliveryCharge = model.DeliveryCharge;
        existing.Address = model.Address;
        existing.MobileNumber = model.MobileNumber;
        existing.DeliveryPersonName = model.DeliveryPersonName;
        existing.DeliveryPersonMobile = model.DeliveryPersonMobile;
        existing.Email = model.Email;
        existing.PaymentMethod = model.PaymentMethod;
        existing.EmergencyContactNumber = model.EmergencyContactNumber;




        _deliveyAgentRepo.Update(existing);
        return existing;

    }
}

