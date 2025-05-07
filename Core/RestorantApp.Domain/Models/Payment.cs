using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Payment : BaseModel
    {
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }
}
