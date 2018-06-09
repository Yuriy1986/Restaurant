using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Meal
    {
        public int Id { get; set; }

        [Required]
        public string NameMeal { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }

        public Meal()
        {
            Dishes = new List<Dish>();
        }
    }
}
