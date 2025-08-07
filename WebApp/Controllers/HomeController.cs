using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController(DataContext dataContext) : Controller
{
    // GET
    public async Task<ViewResult> Index(long id=1)
    {
        var product = await dataContext.Products.FindAsync(id);
        if (product?.CategoryId == 1)
        {
            return View("Watersports", product);
        }
        
        return View(product);
    }

    public IActionResult List() => View(dataContext.Products);


}