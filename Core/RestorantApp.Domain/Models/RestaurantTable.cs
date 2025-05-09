using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class RestaurantTable : BaseModel
    {
        public Guid RestaurantId { get; set; }
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
