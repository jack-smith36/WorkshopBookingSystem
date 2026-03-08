using Microsoft.AspNetCore.Mvc;

namespace WorkshopBookingSystem.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}