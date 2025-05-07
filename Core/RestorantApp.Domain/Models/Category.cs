using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
