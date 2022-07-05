using System.ComponentModel.DataAnnotations;

namespace iShopCore.Entities.config;

public class Company : BaseEntity
{
    [Required]
    public string Name { get; set; }

    public string? Logo { get; set; }
    public string? Location { get; set; }
    public string? CompanyType { get; set; }
    [Required]
    public string OwnersName { get; set; }
    public string? MobileNo { get; set; }
}

