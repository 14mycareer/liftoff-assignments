using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergenAlertMVC2.Models;
using Microsoft.EntityFrameworkCore;

namespace AllergenAlertMVC2.Data
{
    public class RestaurantDbContext : DbContext
    {

        public DbSet<Restaurant> Restaurants { get; set; }


        //constructor for DbContext class
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        { }
    }
}
