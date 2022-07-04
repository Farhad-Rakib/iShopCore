using System.Text.Json.Serialization;

namespace iShopCore.Entities.config
{
    public class ProductSpecDetails:BaseEntity
    {
        public long ProductSpecId { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public ProductSpec ProductSpec { get; set; }
    }
}
