using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Promotion : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Guid> ApplicableMenuItems { get; set; }
    }
}
