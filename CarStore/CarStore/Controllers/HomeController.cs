using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Models;
namespace CarStore.Controllers
{
    public class HomeController : Controller
    {
        CarContext carcontext = new CarContext();
        // GET: Home
        public ActionResult Index()
        {
           
            return View(carcontext.CARSINFO.ToList());
        }
    }
}