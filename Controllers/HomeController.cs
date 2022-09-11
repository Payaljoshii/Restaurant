using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        RestaurantProjectEntities _context = new RestaurantProjectEntities();
        public ActionResult Index()
        {
            var listofdata = _context.Orders.ToList();
            return View(listofdata);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Orders model)
        {
            _context.Orders.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Inserted Successfully";
            return View();
        }

       
    }
}