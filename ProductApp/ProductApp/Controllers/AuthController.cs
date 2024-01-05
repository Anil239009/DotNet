using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult SignIn()
    {

        return View();
    }
    [HttpPost]
    public IActionResult SignIn(string uname, string psw)
    {
        if(uname=="Anil" && psw=="anil@123"){
            return RedirectToAction("bar","Home",null);
        }
        return View();
    }
    [HttpPost]
    public IActionResult Register(string email, string psw, string rpass)
    {
        return Json(new {Email=email, Password=psw, ConfirmPassword=rpass});
    }

    [HttpGet]
    public IActionResult Register(){
        return View();
    }

   
}
