using Microsoft.AspNetCore.Mvc;

namespace PieShopApp.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}