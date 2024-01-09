using BOL;
using BLL;
namespace SAL;
public class EmployeeService:IEmployeeService{
     public List<Employee> GetAll(){
       List<Employee> employees=new List<Employee>();
       /*employees.Add(new Employee{Id=1, Name="Shivam"});
       employees.Add(new Employee{Id=2, Name="Chirag"});
       employees.Add(new Employee{Id=1, Name="Manisha"});
       employees.Add(new Employee{Id=1, Name="shailesh"});*/
       /*RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\Ravi\employees.json";
       employees=mgr.DeSerialize(fileName);
      */
       BIManager mgr=new BIManager();
       employees=mgr.GetAll();
       return employees;
    }
    public Employee GetById(int id){
     /* List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      string fileName=@"D:\Ravi\employees.json";
      employees=mgr.DeSerialize(fileName);
      Employee emp=employees.Find(emp=>emp.Id==id);
     */
      BIManager mgr=new BIManager();
      Employee emp=mgr.GetById(id);
      return emp;
    }
    public void Insert(Employee emp){}
    public void Update(Employee emp){}
    public void Delete(int id){

    }
}