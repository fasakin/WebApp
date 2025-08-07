using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;


public class SecondController : Controller
{
    public IActionResult Index() => View("Common");
    
    
    public IActionResult Common()
    {
        return View();
    }
}