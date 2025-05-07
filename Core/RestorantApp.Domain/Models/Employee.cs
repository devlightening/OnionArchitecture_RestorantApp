using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid RestaurantId { get; set; }
        public string? Photo { get; set; }
    }
}
