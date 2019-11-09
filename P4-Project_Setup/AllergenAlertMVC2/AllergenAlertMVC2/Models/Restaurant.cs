using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllergenAlertMVC2.Models
{
    public class Restaurant
    {

        public string Name { get; set; }
        public int RestaurantId { get; set; }
        private static int nextId = 1;

        
       
        //Default constructor
        public Restaurant()
        {
            RestaurantId = nextId;
            nextId++;


        }
    }
}
