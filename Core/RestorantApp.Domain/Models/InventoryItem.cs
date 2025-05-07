using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class InventoryItem : BaseModel
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Threshold { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
