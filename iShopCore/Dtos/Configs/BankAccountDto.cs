using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class BankAccountDto:BaseEntity
    {

        public long  BankId { get; set; }
       
        public string AccountName { get; set; }
    
        public string AccountNumber { get; set; }

        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }




    }
}
