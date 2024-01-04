using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;

IEmployeeService svc=new EmployeeService();
EmployeesController controller=new EmployeesController(svc);
List<Employee> model=controller.GetAll();
ListView view=new ListView(model);
view.Render();
Console.WriteLine("Welcome to MVC in C#");

IEmployeeService svc1=new EmployeeService();
EmployeesController controller1=new EmployeesController(svc1);
Console.WriteLine("Enter your id : ");
int id=int.Parse(Console.ReadLine());
Employee e1=controller1.GetById(id);
EmployeeView view1=new EmployeeView(e1);
view1.Render();

IEmployeeService svc2=new EmployeeService();
EmployeesController controller2=new EmployeesController(svc1);
Console.WriteLine("Enter your id and name : ");
int id1=int.Parse(Console.ReadLine());
string name=Console.ReadLine();
Employee emp=new Employee{Id=2, Name=name};
Console.WriteLine("Employee Added successfully..!");



IEmployeeService svc3=new EmployeeService();
EmployeesController controller3=new EmployeesController(svc1);
Console.WriteLine("Enter your id : ");
int id3=int.Parse(Console.ReadLine());
controller1.GetById(id3);
Console.WriteLine("Employee removed successfully..!");

