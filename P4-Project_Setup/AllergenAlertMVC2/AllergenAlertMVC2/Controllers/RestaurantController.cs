using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC2.Models;
using System.Collections.Generic;
using AllergenAlertMVC2.ViewModels;
using AllergenAlertMVC2.Data;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class RestaurantController : Controller
    {
        //create local variable of the DbContext type to use within controller to access database
        private RestaurantDbContext context;

        //constructor that takes instance of data that is of DbContext type
        public RestaurantController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }
               
        // GET: /<controller>/
        public IActionResult Index()
        {
           
            //makes list of restaurant type out of restaurant data of DbContext type from a database
            List<Restaurant> restaurants = context.Restaurants.ToList();

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
            if (ModelState.IsValid)
            {
                Restaurant newRestaurant = new Restaurant
                {
                    Name = addRestaurantViewModel.Name
                };
                //adds to database making changes
                context.Restaurants.Add(newRestaurant);
                //saves above changes to database
                context.SaveChanges();

                return Redirect("/Restaurant");

            }
            return View(addRestaurantViewModel);

        }

        //method to remove a restaurant from the listing
        public IActionResult RemoveRestaurant()
        {
            ViewBag.title = "REMOVE RESTAURANTS";

            //shows existing list of restaurants
            ViewBag.restaurants = context.Restaurants.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult RemoveRestaurant(int[] restaurantIds)
        {
            foreach (int restaurantId in restaurantIds)
            {
                // locate restaurant using selected restaurants id to remove from list
                Restaurant theRestaurant = context.Restaurants.Single(r => r.ID == restaurantId);

                context.Restaurants.Remove(theRestaurant);

            }
            context.SaveChanges();
            


            return Redirect("/");

        }

    }
}
