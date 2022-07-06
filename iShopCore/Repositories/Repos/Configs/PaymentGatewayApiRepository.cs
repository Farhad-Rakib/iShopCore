using iShopCore.Entities.config;
using iShopCore.Repositories.Interfaces;
using iShopCore.Repositories.Interfaces.Configs;
using Microsoft.EntityFrameworkCore;

namespace iShopCore.Repositories.Repos.Configs;

public class PaymentGatewayApiRepository : IPaymentGatewayApiRepository

{
    private IBaseRepository<PaymentGatewayAPI> _paymentGatewayApiRepo;

    public PaymentGatewayApiRepository(IBaseRepository<PaymentGatewayAPI> paymentGatewayApiRepo)
    {
        _paymentGatewayApiRepo = paymentGatewayApiRepo;
    }

    public async Task<PaymentGatewayAPI> AddAsync(PaymentGatewayAPI model)
    {
        _paymentGatewayApiRepo.Insert(model);
        _paymentGatewayApiRepo.Save();
        return model;
    }



    public async Task<long> DeleteAsync(long id)
    {
        var existing = await _paymentGatewayApiRepo.GetById(id);

        if (existing != null)
        {
            _paymentGatewayApiRepo.Delete(id);
            _paymentGatewayApiRepo.Save();
            return id;
        }
        else
        {
            throw new ArgumentException("Product Spec Details is not exist");
        }



    }

    public async Task<IEnumerable<PaymentGatewayAPI>> GetAllAsync()
    {
        var productSpecs = await _paymentGatewayApiRepo.GetAll();
        return productSpecs.ToList();

    }

    public async Task<PaymentGatewayAPI> GetAsync(long id)
    {
        var data = await _paymentGatewayApiRepo.GetById(id);
        if (data == null)
            throw new ArgumentException("Product Spec Details is not exist");
        return data;
    }

    public async Task<PaymentGatewayAPI> UpdateAsync(PaymentGatewayAPI model)
    {
        var existing = await _paymentGatewayApiRepo.FindBy(c => c.Id == model.Id).FirstOrDefaultAsync();
        if (existing == null)
            throw new ArgumentException("Company is not exist");

        existing.Id = model.Id;
        existing.UpdatedDate = model.UpdatedDate;
        existing.UpdatedBy = model.UpdatedBy;
        existing.ApiName = model.ApiName;
        existing.ApiUserName = model.ApiUserName;
        existing.ApiPassword = model.ApiPassword;
        existing.ApiKey = model.ApiKey;
        existing.StoreId = model.StoreId;
        existing.SuccessUrl = model.SuccessUrl;
        existing.FailUrl = model.FailUrl;
        existing.CancelUrl = model.CancelUrl;
        existing.BankAccountId = model.BankAccountId;
        existing.ApiUrl = model.ApiUrl;


        _paymentGatewayApiRepo.Update(existing);
        return existing;

    }
}

