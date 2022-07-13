using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class AccountType : BaseEntity
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public string Source { get; set; }
        public string Comments { get; set; }



    }
}
