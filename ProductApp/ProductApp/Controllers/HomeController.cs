using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   public IActionResult AddProduct()
    {
        return View();
    }
}
