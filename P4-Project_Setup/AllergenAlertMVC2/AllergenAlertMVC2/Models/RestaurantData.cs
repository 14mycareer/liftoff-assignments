using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllergenAlertMVC2.Models
{
    public class RestaurantData
    {
        static private List<Restaurant> restaurants = new List<Restaurant>();

        //create methods to manage the data like: get all restaurants listing, add to listing, remove from listing,etc

        //GetAll (retrieve listing)
        public static List<Restaurant> GetAll()
        {
            return restaurants;
        }


        //Add a Restaurant
        public static void AddRestaurant(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
        }


        //Remove a Restaurant
        public static void RemoveRestaurant(int id)
        {
            Restaurant restaurantToRemove = GetById(id);

            restaurants.Remove(restaurantToRemove);
        }


        //GetById (modify listing by Restaurant's id in database
        public static Restaurant GetById(int id)
        {
            return restaurants.Single(x => x.RestaurantId == id);
        }
       
    }
}
