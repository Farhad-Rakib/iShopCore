using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class Bank:BaseEntity
    {
 
        [Required]
        public string Name { get; set; }
        [Required]
        public string Branch { get; set; }
        [Required]
        public string Code { get; set; }

    }
}
