using iShopCore.Dtos;

namespace iShopCore.Entities.config
{
    public class DiscountDto : BaseDtos
    {

        public string DiscountType { get; set; }
        public string DiscountRate { get; set; }
        public DateTime DiscountStartTime { get; set; }
        public DateTime DiscountEndTime { get; set; }

    }
}

