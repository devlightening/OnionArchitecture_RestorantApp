using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Shift : BaseModel
    {
        public Guid EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid RestaurantId { get; set; }
        public string ShiftType { get; set; }
    }
}
