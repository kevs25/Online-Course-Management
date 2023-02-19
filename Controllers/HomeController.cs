using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webapp.Models;

namespace Webapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    
        
    public IActionResult Index()
    {
            return View();
        
    }
    

    public IActionResult Contact()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(LoginModel login)
    {
        return View("success",login);
    }
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }
    [HttpPost]

   
    public IActionResult SignUp(SignUpModel register)
    {
        int choice = ValidationModel.signupValidation();
        if(choice == 1)
            return View("Index");
        if(choice == 2)
            return View("success1",register);
        else
            return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
