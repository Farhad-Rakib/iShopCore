namespace iShopCore.Dtos.Configs
{
    public class CompanyConfigsDto:BaseDtos
    {
        public string Name { get; set; }

        public string? Logo { get; set; }
        public string? Location { get; set; }
        public string? CompanyType { get; set; }
        public string OwnersName { get; set; }
        public string? MobileNo { get; set; }

    }
}
