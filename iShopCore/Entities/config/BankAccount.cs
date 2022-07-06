using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class BankAccount:BaseEntity
    {

        public long  BankId { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string AccountNumber { get; set; }

        [JsonIgnore]
        public Bank Bank { get; set; }

    }
}
