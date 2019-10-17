using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        // START CONTROLLER //
        //////////////////////
            [HttpGet("")]
            public ViewResult Index()
            {
            return View();
            } 
    }
}