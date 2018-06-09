using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    [Table("Chefs")]
    public class Chef : Employee
    {
        public virtual ICollection<Order> Orders { get; set; }

        public Chef()
        {
            Orders = new List<Order>();
        }
    }
}
