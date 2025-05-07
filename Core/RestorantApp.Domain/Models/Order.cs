using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Order : BaseModel
    {
        public Guid CustomerId { get; set; }
        public Guid RestaurantId { get; set; }
        public Guid TableId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid PaymentId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
