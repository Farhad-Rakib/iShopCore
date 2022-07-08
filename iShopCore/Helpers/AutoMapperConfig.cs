using AutoMapper;
using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;

namespace iShopCore.Helpers
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Company , CompanyDto>().ReverseMap();
                config.CreateMap<ProductSpec , ProductSpecDto>().ReverseMap();
                config.CreateMap<ProductSpecDetails , ProductSpecDetailsDto>().ReverseMap();
                config.CreateMap<Discount , DiscountDto>().ReverseMap();
                config.CreateMap<DeliveryAgent , DeliveryAgentDto>().ReverseMap();
            

            });

            return mappingConfig;
        }
    }
}
