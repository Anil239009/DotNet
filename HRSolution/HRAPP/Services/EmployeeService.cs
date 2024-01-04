using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{

      List<Employee> employees=new List<Employee>();  
      RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\DotNet\DotNet\HRSolution\employees.json";

       public EmployeeService(){
           employees=mgr.DeSerialize(fileName);

       }
    public List<Employee> GetAll(){
      
      //  List<Employee> employees=new List<Employee>();
       /*employees.Add(new Employee{Id=1, Name="Shivam"});
       employees.Add(new Employee{Id=2, Name="Chirag"});
       employees.Add(new Employee{Id=1, Name="Manisha"});
       employees.Add(new Employee{Id=1, Name="shailesh"});*/
       
     
       return employees;
    }
    public Employee GetById(int id){
    
     return employees.Find(e=>e.Id==id);
      
    }
    public void Insert(Employee emp){
      employees.Add(emp);
    }
     public void Update(Employee emp){}
     public void Delete(int id){
      Employee e=employees.Find(e=>e.Id==id);
        employees.Remove(e);
      }

      ~EmployeeService(){
         mgr.Serialize(employees,fileName);
      }

}