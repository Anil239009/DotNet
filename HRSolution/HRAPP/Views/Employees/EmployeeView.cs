using HRAPP.Entities;
using HRAPP.Views;

public class EmployeeView:IView{
    public Employee emp;

    public EmployeeView(Employee _emp){
        this.emp=_emp;
    }
    public void Render(){
        Console.WriteLine(emp.Id+" "+emp.Name);
    }
}