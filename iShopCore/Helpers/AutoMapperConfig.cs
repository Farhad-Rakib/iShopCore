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
                config.CreateMap<CompanyConfigsDto, Company>().ReverseMap();
                //config.CreateMap<User, UserAuthenticateResponse>();

            });

            return mappingConfig;
        }
    }
}
