using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs;

public class BankRepository : IBankRepository

{
    private IBaseRepository<Bank> _bankRepo;

    public BankRepository(IBaseRepository<Bank> bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public async Task<Bank> AddAsync(Bank model)
    {
        _bankRepo.Insert(model);
        _bankRepo.Save();
        return model;
    }

    public async Task<long> DeleteAsync(long id)
    {
        var existing = await _bankRepo.GetById(id);

        if (existing != null)
        {
            _bankRepo.Delete(id);
            _bankRepo.Save();
            return id;
        }
        else
        {
            throw new ArgumentException("Bank not exist");
        }
    }

    public async Task<IEnumerable<Bank>> GetAllAsync()
    {
        var data = await _bankRepo.GetAll();
        return data.ToList();

    }

    public async Task<Bank> GetAsync(long id)
    {
        var data = await _bankRepo.GetById(id);
        if (data == null)
            throw new ArgumentException("Bank not exist");
        return data;
    }

    public async Task<Bank> UpdateAsync(Bank model)
    {
        var existing = await _bankRepo.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
        if (existing == null)
            throw new ArgumentException("Bank not exist");

        existing.Id = model.Id;
        existing.UpdatedDate = model.UpdatedDate;
        existing.UpdatedBy = model.UpdatedBy;
        existing.Name = model.Name;
        existing.Branch = model.Branch;
        existing.Code = model.Code;
     


        _bankRepo.Update(existing);
        return existing;

    }
}

