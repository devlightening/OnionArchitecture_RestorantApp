namespace RestorantApp.Domain.Models.BaseModels
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; } 
        public string? UpdatedUser { get; set; }
        public string? Description { get; set; }
    }
}
