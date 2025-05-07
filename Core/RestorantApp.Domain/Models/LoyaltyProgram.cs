using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class LoyaltyProgram : BaseModel
    {
        public Guid CustomerId { get; set; }
        public int Points { get; set; }
        public string Tier { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
