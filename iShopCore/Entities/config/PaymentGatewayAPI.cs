using System.ComponentModel.DataAnnotations;

namespace iShopCore.Entities.config;

public class PaymentGatewayAPI : BaseEntity
{
    [Required]
    public string ApiName { get; set; }

    public string BankAccountId { get; set; }
    [Required]
    public string ApiUrl { get; set; }
    [Required]
    public string ApiUserName { get; set; }
    [Required]
    public string ApiPassword { get; set; }

    [Required]
    public string ApiKey { get; set; }
   
    [Required]
    public string StoreId { get; set; }
    [Required]
    public string SuccessUrl { get; set; }
    public string? FailUrl { get; set; }
    public string? CancelUrl { get; set; }
}

