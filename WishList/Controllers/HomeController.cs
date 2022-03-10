using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return Error();
        }
        public IActionResult Index()
        {
            return Index();
        }


    }
}
