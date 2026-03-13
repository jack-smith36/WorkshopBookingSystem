using Microsoft.AspNetCore.Mvc;

namespace WorkshopBookingSystem.Controllers.V1;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        IActionResult result = Ok(new { message = "Hello from AuthController" });
        
        return result;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> getById(int id)
    {
        IActionResult result = Ok(new { message = "Hello from AuthController", id = id});
        
        return result;
    }
    
}