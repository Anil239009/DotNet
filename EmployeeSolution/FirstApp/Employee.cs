using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal sealed class Employee:Person
    {
        public float BasicSalary { get; set; }
        public float DailyAllowance { get;set; }
        public float Deductions { get; set; }
        public Employee():base() {
        }

        public Employee( int id, string name, int age, float basicSalary, float dailyAllowance, float deductions):base(id, name,age)
        {
            BasicSalary = basicSalary;
            DailyAllowance = dailyAllowance;
            Deductions = deductions;
        }


        public float ComputePay()
        {
            float salary=BasicSalary+( DailyAllowance* 20)- Deductions;
            return salary;
        }
        public override string ToString()
        {
            return base.ToString() + " Salary=" +this.ComputePay() ;
        }
    }
}
