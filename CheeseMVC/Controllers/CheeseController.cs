using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private List<Dictionary<string, string>> CheesesListDict = new List<Dictionary<string, string>>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.CheesesListDict = CheesesListDict;
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult AddNewCheese(string cheesename, string cheesedescription)
        {
            foreach(Dictionary<string, string> cheesedict in CheesesListDict)
            {
                cheesedict.Add(cheesename, cheesedescription);
            }

            ViewBag.CheesesListDict = CheesesListDict;

            return Redirect("/Cheese");
        }
    }
}
