using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Restaurant.WEB.Models
{
    public class OrderViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name ="Дата: ")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDateTime { get; set; }

        [Display(Name = "Заказано: ")]
        public List<string> Dishes { get; set; }

        [Display(Name = "Стоимость (грн.): ")]
        public decimal OrderPrice { get; set; }

        //  Visitor`s table number
        [Display(Name = "Номер стола: ")]
        public int NumberTable { get; set; }

        [Display(Name = "Выполнен")]
        public bool Executed { get; set; }

        [Display(Name = "Оплачен")]
        public bool Paid { get; set; }
        
        [Display(Name = "Повар(а): ")]
        public List<string> Chefs { get; set; }

        [Display(Name = "Официант(ы): ")]
        public List<string> Waiters { get; set; }
    }
}