using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class OrderItem : BaseModel
    {
        public Guid OrderId { get; set; }
        public Guid MenuItemId { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
