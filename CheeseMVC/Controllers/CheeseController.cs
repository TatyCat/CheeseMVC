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

// renamed route handler to Add so route naming is not needed
        // [Route("/Cheese/Add")]
        // public IActionResult AddNewCheese(string cheesename, string cheesedescription)
        [HttpPost]
        public IActionResult Add(string cheesename, string cheesedescription)
        {
            CheesesList.Add(cheesename, cheesedescription);

            return Redirect("/Cheese");
        }
        
// this view is not necessary. see code in the Cheese/index.cshtml file
        // public IActionResult Remove()
        // {
        //     if(CheesesList.Count >0)
        //     {
        //         ViewBag.CheesesList = CheesesList;
        //         return View();
        //     }

        //     else
        //     {
        //         return Redirect("/Cheese");
        //     }
            
        // }

        [HttpPost]
        public IActionResult Remove(string name)
        {
            
            //i want to remove the user selected cheese from the cheeses string dictionary

            //i dont need to check if it's contained bc the user is selecting from a list of cheeses already in the dict. 
            //@cheese.Key is a string i'm passing in. 
            //to theck if it works, i'll just redirect to the cheese page...maybe that's the problem. 
            
            CheesesList.Remove(name);

            return Redirect("/Cheese");
        }
    }
}
