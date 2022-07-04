namespace iShopCore.Dtos
{
    public class BaseDtos
    {

        public BaseDtos()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsActive = 1;
        }
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public int IsActive { get; set; }
    }
}
