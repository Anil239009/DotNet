using System.ComponentModel.DataAnnotations;

namespace BOL;

[Serializable]
public class Employee{
    public int Id{get;set;}
    [Required]
    public string FirstName{get;set;}
    [Required]
    public string LastName{get;set;}
    [Required]
    public string Email{get;set;}
    public string Address{get;set;}
    public string Password{get;set;}
    public int  DepartmentId{get;set;}
    public int ManagerId{get;set;}

}
