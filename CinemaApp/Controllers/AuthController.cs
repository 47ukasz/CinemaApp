using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Controllers;

public class AuthController : Controller {
    public ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger) {
        _logger = logger;
    }

    public IActionResult Register() {
        _logger.LogInformation("Register");
        
        return View();
    }
    
}