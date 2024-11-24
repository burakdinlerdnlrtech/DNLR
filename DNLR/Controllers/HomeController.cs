using Microsoft.AspNetCore.Mvc;

namespace DNLR.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}