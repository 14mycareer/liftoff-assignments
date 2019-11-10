using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC2.Models;
using System.Collections.Generic;
using AllergenAlertMVC2.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class RestaurantController : Controller
    {
       
        // GET: /<controller>/
        public IActionResult Index()
        {
           

            List<Restaurant> restaurants = RestaurantData.GetAll();

            return View(restaurants);
        }

        //Method to create a form to add a restaurant to a list of restaurants
        public IActionResult AddRestaurant()
        {
            AddRestaurantViewModel addRestaurantViewModel = new AddRestaurantViewModel();
            return View(addRestaurantViewModel);
        }

        [HttpPost]
        //Method to add new restaurant to existing list

        public IActionResult AddRestaurant(AddRestaurantViewModel addRestaurantViewModel)
        {
            Restaurant newRestaurant = new Restaurant
            {
                Name = addRestaurantViewModel.Name
            };

            RestaurantData.AddRestaurant(newRestaurant);
            
            return Redirect("/Restaurant");

        }

        //method to remove a restaurant from the listing
        public IActionResult RemoveRestaurant()
        {
            ViewBag.title = "REMOVE RESTAURANTS";

            //shows existing list of restaurants
            ViewBag.restaurants = RestaurantData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult RemoveRestaurant(int[] restaurantIds)
        {
            foreach (int restaurantId in restaurantIds)
            {
                // to do remove restaurant from list
                RestaurantData.RemoveRestaurant(restaurantId);

            }
            


            return Redirect("/");

        }

    }
}
