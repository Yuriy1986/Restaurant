using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string SecondName { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime WorksFromDay { get; set; }

        public DateTime? DismissedFromDay { get; set; }
    }
}
