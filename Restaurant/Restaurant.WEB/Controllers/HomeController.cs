using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Restaurant.BLL.DTO;
using Restaurant.WEB.Models;
using Restaurant.BLL.Interfaces;

namespace Restaurant.WEB.Controllers
{
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService service)
        {
            orderService = service;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllOrders()
        {
            var orders = Mapper.Map<IEnumerable<DTOOrderViewModel>, IEnumerable<OrderViewModel>>(orderService.GetAllOrders());
            return View(orders);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Построение базы данных для простой системы учета заказов в ресторане";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Связаться с Админом";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            orderService.Dispose();
            base.Dispose(disposing);
        }
    }
}