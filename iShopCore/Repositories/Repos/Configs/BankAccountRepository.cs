using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs;

public class BankAccountRepository : IBankAccountRepository

{
    private IBaseRepository<BankAccount> _bankAccountRepo;

    public BankAccountRepository(IBaseRepository<BankAccount> bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public async Task<BankAccount> AddAsync(BankAccount model)
    {
        _bankAccountRepo.Insert(model);
        _bankAccountRepo.Save();
        return model;
    }

    public async Task<long> DeleteAsync(long id)
    {
        var existing = await _bankAccountRepo.GetById(id);

        if (existing != null)
        {
            _bankAccountRepo.Delete(id);
            _bankAccountRepo.Save();
            return id;
        }
        else
        {
            throw new ArgumentException("Bank not exist");
        }
    }

    public async Task<IEnumerable<BankAccount>> GetAllAsync()
    {
        var data = await _bankAccountRepo.GetAll();
        return data.ToList();

    }

    public async Task<BankAccount> GetAsync(long id)
    {
        var data = await _bankAccountRepo.GetById(id);
        if (data == null)
            throw new ArgumentException("Bank not exist");
        return data;
    }

    public async Task<BankAccount> UpdateAsync(BankAccount model)
    {
        var existing = await _bankAccountRepo.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
        if (existing == null)
            throw new ArgumentException("Bank not exist");

        existing.Id = model.Id;
        existing.UpdatedDate = model.UpdatedDate;
        existing.UpdatedBy = model.UpdatedBy;
        existing.AccountName = model.AccountName;
        existing.AccountNumber = model.AccountNumber;
        existing.BankId = model.BankId;
     


        _bankAccountRepo.Update(existing);
        return existing;

    }
}

