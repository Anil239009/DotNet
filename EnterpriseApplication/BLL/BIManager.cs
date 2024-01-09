using BOL;
using DAL;
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

}
