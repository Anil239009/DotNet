using System.Data.Common;

namespace employee;

public class Employee{
    private  int id{get;}

    protected String fName{set;get;}

    protected String lName{set;get;}

    protected float basic_sal{set;get;}

   public Employee(int id,string fName,string lName,float basic_sal){
    this.id=id;
    this.fName=fName;
    this.lName=lName;
    this.basic_sal=basic_sal;
   }

   public int getId(){
    return this.id;
   }

   public virtual float computeSal(){
    return 0;
   }
    public virtual string EmployeeNameAndSal(){
        return null;
    }
    public override string ToString()
    {
        return "Employee details are : "+id+" "+fName+" "+lName;
    }

}

public class HR:Employee{
    private float daily_Allowance{get;set;}

    private float tax{get;set;}

    public HR(float daily_Allowance,float tax, int id,string fName,string lName,float basic_sal): base(id,fName,lName,basic_sal){
        this.daily_Allowance=daily_Allowance;
        this.tax=tax;
    }

    public float computeSal(){
        return basic_sal=(basic_sal+(daily_Allowance*20))-tax;
    }

    public override string ToString()
    {
        return base.ToString()+" "+computeSal();
    }

    public  string EmployeeNameAndSal(){
    return this.fName+" "+computeSal();
   }
}