using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class DeliveryAgentDto : BaseEntity
    {


        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string DeliveryCharge { get; set; }
        public string PaymentMethod { get; set; }
        public string MobileNumber { get; set; }
        [Required]
        public string DeliveryPersonName { get; set; }
        [Required]
        public string DeliveryPersonMobile { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string Email { get; set; }



    }
}
