using HRAPP.Entities;
using HRAPP.Views;

public class EmployeeView:IView{
    public Employee emp;

    public EmployeeView(Employee emp){
        this.emp=emp;
    }
    public void Render(){
        Console.WriteLine(emp.Id+" "+emp.Name);
    }
}