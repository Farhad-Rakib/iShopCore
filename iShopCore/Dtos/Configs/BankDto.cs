using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class BankDto:BaseEntity
    {
 
       
        public string Name { get; set; }
       
        public string Branch { get; set; }
     
        public string Code { get; set; }

    }
}
