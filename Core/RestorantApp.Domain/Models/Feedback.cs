using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Feedback : BaseModel
    {
        public Guid CustomerId { get; set; }
        public Guid RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
