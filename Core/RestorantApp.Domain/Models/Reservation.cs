using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Reservation : BaseModel
    {
        public Guid CustomerId { get; set; }
        public Guid RestaurantId { get; set; }
        public Guid TableId { get; set; }
        public DateTime ReservationTime { get; set; }
        public int NumberOfGuests { get; set; }
        public string Status { get; set; }
    }
}
