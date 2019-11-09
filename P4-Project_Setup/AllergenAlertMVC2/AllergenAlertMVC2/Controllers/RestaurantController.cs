using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class RestaurantController : Controller
    {
        static private List<Restaurant> Restaurants = new List<Restaurant>();
        // GET: /<controller>/
        public IActionResult Index()
        {
           

            ViewBag.restaurants = Restaurants;

            return View();
        }

        //Method to create a form to add a restaurant to a list of restaurants
        public IActionResult AddRestaurant()
        {
            return View();
        }

        [HttpPost]
        [Route("/Restaurant/AddRestaurant")]

        //Method to add new restaurant to existing list

        public IActionResult NewRestaurant(string name)
        {
            Restaurant newRestaurant = new Restaurant
            {
                Name = name
            };
            Restaurants.Add(newRestaurant);

            return Redirect("/Restaurant");

        }

        //method to remove a restaurant from the listing
        public IActionResult RemoveRestaurant()
        {
            ViewBag.title = "REMOVE RESTAURANTS";
            //shows existing list of restaurants
            ViewBag.retaurants = Restaurants;
            return View();


        }

    }
}
