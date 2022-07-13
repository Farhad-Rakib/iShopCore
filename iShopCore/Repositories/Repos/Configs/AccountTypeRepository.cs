using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs;

public class AccountTypeRepository : IAccountTypeRepository

{
    private IBaseRepository<AccountType> _accountTypeRepo;

    public AccountTypeRepository(IBaseRepository<AccountType> accountTypeRepo)
    {
        _accountTypeRepo = accountTypeRepo;
    }

    public async Task<AccountType> AddAsync(AccountType model)
    {
        _accountTypeRepo.Insert(model);
        _accountTypeRepo.Save();
        return model;
    }

    public async Task<long> DeleteAsync(long id)
    {
        var existing = await _accountTypeRepo.GetById(id);

        if (existing != null)
        {
            _accountTypeRepo.Delete(id);
            _accountTypeRepo.Save();
            return id;
        }
        else
        {
            throw new ArgumentException("Bank not exist");
        }
    }

    public async Task<IEnumerable<AccountType>> GetAllAsync()
    {
        var data = await _accountTypeRepo.GetAll();
        return data.ToList();

    }

    public async Task<AccountType> GetAsync(long id)
    {
        var data = await _accountTypeRepo.GetById(id);
        if (data == null)
            throw new ArgumentException("Bank not exist");
        return data;
    }

    public async Task<AccountType> UpdateAsync(AccountType model)
    {
        var existing = await _accountTypeRepo.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
        if (existing == null)
            throw new ArgumentException("Account Type not exist");

        existing.Id = model.Id;
        existing.UpdatedDate = model.UpdatedDate;
        existing.UpdatedBy = model.UpdatedBy;
        existing.Name = model.Name;
        existing.Type = model.Type;
        existing.Source = model.Source;
        existing.Comments = model.Comments;



        _accountTypeRepo.Update(existing);
        return existing;

    }
}

