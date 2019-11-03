using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello World of Restaurants!");
        }
    }
}
