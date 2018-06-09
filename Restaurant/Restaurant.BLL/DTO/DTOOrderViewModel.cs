using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.DTO
{
    public class DTOOrderViewModel
    {
        public int Id { get; set; }

        public DateTime OrderDateTime { get; set; }

        public decimal OrderPrice { get; set; }

        //  Visitor`s table number
        public int NumberTable { get; set; }

        public bool Executed { get; set; }

        public bool Paid { get; set; }

        public List<string> Dishes { get; set; }

        public List<string> Chefs { get; set; }

        public List<string> Waiters { get; set; }
    }
}