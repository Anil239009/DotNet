using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;
using SAL;

namespace EStoreWebApp.Controllers;
public class EmployeesController : Controller
{

    string _conString = @"server=localhost; port=3306; user=root; password=password; database=transflower";
    private readonly IEmployeeService _svc;
    private readonly IConfiguration _configuration;
    public EmployeesController(IEmployeeService svc, IConfiguration configuration)
    {
        Console.WriteLine("Employee Controller Constructor is being Invoked..");
        this._svc = svc;
        this._configuration = configuration;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var connString = _configuration.GetConnectionString("TransflowerDb");
        List<Employee> employees = _svc.GetAll();
        TempData["allEmployees"] = employees;
        return View();
    }


    public IActionResult List()
    {
        Console.WriteLine("Employee Index Action Method is called...");
        List<Employee> employees = _svc.GetAll();
        return View(employees);
    }
    public IActionResult Details(int id)
    {
        Employee emp = _svc.GetById(id);
        return View(emp);
    }


    //Get Request Handler
    public IActionResult Edit(int id)
    {
        List<Employee> employees = _svc.GetAll();
        var e = employees.Find((emp) => emp.Id == id);
        return View(e);
    }


    [HttpPost]
    public IActionResult Edit(Employee emp)
    {
        Console.WriteLine(emp.Id + " " + emp.FirstName + "  " + emp.LastName);
        if (emp != null)
        {

            Console.WriteLine("In update of employee controller");
            _svc.Update(emp);
            Console.WriteLine("here");
            return RedirectToAction("Index", "Employees", null);
        }
        else
            return View(emp);
    }

    public IActionResult Delete(int id)
    {
        Console.WriteLine("id delete controller" + id);

        _svc.Delete(id);
        return RedirectToAction("Index", "Employees", null);
    }
}
