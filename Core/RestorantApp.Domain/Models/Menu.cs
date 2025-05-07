using RestorantApp.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Domain.Models
{
    public class Menu : BaseModel
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
