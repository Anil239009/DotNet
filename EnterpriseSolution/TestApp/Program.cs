
using BOL;
using DAL.DisConnected;

MySqlDBManager mgr=new MySqlDBManager();
List<Employee> employees=mgr.GetAll();
Console.WriteLine("Employee Count= " +employees.Count);


Employee emp=new Employee();
emp.Id=99;
//bool status=mgr.Delete(emp);

Employee emp1=new Employee();
emp1.FirstName="Chetana";
emp1.LastName="Jadhav";
emp1.Email="chetana.jadhav@transflower.in";
emp1.Address="Chitgaon";
emp1.Password="5654";


bool status=mgr.Insert(emp1);
Console.WriteLine("Status= "+ status);

employees=mgr.GetAll();
Console.WriteLine("Employee Count= " +employees.Count);
