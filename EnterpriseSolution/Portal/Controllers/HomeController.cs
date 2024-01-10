using System.Diagnostics;
using FormsTagHelper.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register(){

        RegisterViewModel model=new RegisterViewModel();
        model.Email="ravi.tambade@transflower.in";
        model.Password="12234";
        return View(model);
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model){

        Console.WriteLine( model.Email + "  "+ model.Password);
        return View(model);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
