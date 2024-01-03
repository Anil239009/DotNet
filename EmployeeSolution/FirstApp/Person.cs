using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        public static int count;
        //data members
        private int id;
        private string name;
        private int age;

        //Property: This feature is inspired from VB
        public int Id 
        { get { return id; }
          set { id = value; }
        }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } } 

        //constructor overloading
        public Person() {
            this.id = 0;
            this.age = 0;
            this.name = string.Empty;
            count++;
        } 
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            count++;
        }
        ~Person() {

            count--;
        }
        public override string ToString()
        {
           return  base.ToString()+"  : "  + this.Id+" "+ this.Name + " "+ this.age;
        }
    }
}
