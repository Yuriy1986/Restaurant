using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDateTime { get; set; }

        public decimal OrderPrice { get; set; }

        //  Visitor`s table number
        public int NumberTable { get; set; }

        public bool Executed { get; set; }

        public bool Paid { get; set; }

        public ICollection<Dish> Dishes { get; set;}

        public ICollection<Chef> Chefs { get; set; }

        public ICollection<Waiter> Waiters { get; set; }

        public Order()
        {
            Dishes = new List<Dish>();
            Chefs = new List<Chef>();
            Waiters = new List<Waiter>();
        }
    }
}
