using RestorantApp.Domain.Models.BaseModels;

namespace RestorantApp.Domain.Models
{
    public class Ingredient : BaseModel
    {
        public string Name { get; set; }
        public string AllergenInfo { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
        public string? Photo { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
