namespace iShopCore.Entities;

public class BaseEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        UpdatedDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        IsActive = 1;
    }
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public long CreatedBy { get; set; }
    public long UpdatedBy { get; set; }
    public int IsActive { get; set; }
    
}

