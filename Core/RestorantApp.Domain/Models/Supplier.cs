using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public ICollection<string> SuppliedItems { get; set; }
    }
}
