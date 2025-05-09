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
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}
