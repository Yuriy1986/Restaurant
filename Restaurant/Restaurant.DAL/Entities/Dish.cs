using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        public Meal Meal { get; set; }

        public int MealId { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Dish()
        {
            Orders = new List<Order>();
        }
    }
}
