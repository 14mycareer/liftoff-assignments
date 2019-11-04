using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> restaurants = new List<string>();
            restaurants.Add("Qdoba");
            restaurants.Add("Panera");
            restaurants.Add("Chipotle");

            ViewBag.restaurants = restaurants;

            return View();
        }

        //Method to create a form to add a restaurant to a list of restaurants
        public IActionResult AddRestaurant()
        {
            return View();
        }
    }
}
