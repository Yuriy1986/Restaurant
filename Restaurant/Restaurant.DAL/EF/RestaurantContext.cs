using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL.Entities;
using System.Data.Entity;

namespace Restaurant.DAL.EF
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Waiter> Waiters { get; set; }

        static RestaurantContext()
        {
            Database.SetInitializer<RestaurantContext>(new UserDbInitializer());
        }

        public RestaurantContext(string conectionString) : base(conectionString)
        {

        }
    }

    public class UserDbInitializer : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var meal1 = context.Meals.Add(new Meal { NameMeal = "Напитки" });
            context.Meals.Add(new Meal { NameMeal = "Десерты" });
            context.Meals.Add(new Meal { NameMeal = "Салаты" });
            context.Meals.Add(new Meal { NameMeal = "Первые блюда" });
            var meal2 = context.Meals.Add(new Meal { NameMeal = "Закуски" });

            var chef = context.Chefs.Add(new Chef
            {
                Surname = "Иванов",
                Name = "Иван",
                SecondName = "Иванович",
                BirthDay = new DateTime(1995, 12, 30),
                WorksFromDay = new DateTime(2015, 1, 25)
            });

            var waiter1 = context.Waiters.Add(new Waiter
            {
                Surname = "Петров",
                Name = "Петр",
                SecondName = "Петрович",
                BirthDay = new DateTime(1990, 12, 15),
                WorksFromDay = new DateTime(2015, 1, 25)
            });

            var waiter2 = context.Waiters.Add(new Waiter
            {
                Surname = "Сидоров",
                Name = "Петр",
                SecondName = "Петрович",
                BirthDay = new DateTime(1990, 2, 15),
                WorksFromDay = new DateTime(2015, 1, 25)
            });

            var dish1 = context.Dishes.Add(new Dish { Meal = meal1, Name = "Компот", Price = 10.50m });
            var dish2 = context.Dishes.Add(new Dish { Meal = meal2, Name = "Картошка фри", Price = 30m });

            var order1 = context.Orders.Add(new Order
            {
                OrderDateTime = new DateTime(2018,5,31,20,10,0),
                OrderPrice = 40.5m,
                NumberTable = 1,
                Executed = false,
                Paid = false
            });
            order1.Dishes.Add(dish1);
            order1.Dishes.Add(dish2);

            order1.Chefs.Add(chef);
            order1.Waiters.Add(waiter1);
            order1.Waiters.Add(waiter2);

            var order2 = context.Orders.Add(new Order
            {
                OrderDateTime = new DateTime(2018, 5, 31, 20, 30, 0),
                OrderPrice = 10.5m,
                NumberTable = 2,
                Executed = false,
                Paid = true
            });
            order2.Dishes.Add(dish1);

            order2.Chefs.Add(chef);
            order2.Waiters.Add(waiter1);
        }
    }
}