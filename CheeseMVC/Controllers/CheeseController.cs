using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> CheesesList = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.CheesesList = CheesesList;
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string cheesename, string cheesedescription)
        {
            CheesesList.Add(cheesename, cheesedescription);

            return Redirect("/Cheese");
        }


        public IActionResult Remove()
        {
           return Redirect("/Cheese");
        }

        [HttpPost]
        public IActionResult Remove(string name)
        {
            CheesesList.Remove(name);

            return Redirect("/Cheese");
        }
    }
}
