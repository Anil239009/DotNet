using BOL;
// using DAL.Connected;
using DAL.DisConnected;
namespace BLL;

public class BIManager
{

    public List<Employee> GetAll(){
        MySqlDBManager mgr=new MySqlDBManager();
        List<Employee> employees=mgr.GetAll();
        //LINQ
        return employees;
    }

    public  Employee GetById(int id){
        MySqlDBManager mgr=new MySqlDBManager();
        Employee employee=mgr.GetById(id);
        return employee;
    }
    public void DeleteById(int id){
        MySqlDBManager mgr=new MySqlDBManager();
        mgr.Delete(id);
    }

    public void Update(Employee employee)
    {
        MySqlDBManager mgr = new MySqlDBManager();
        mgr.Update(employee);
    }

}
