using employee;
using System.Collections.Generic;



HR h1=new HR(2000,4000,1,"Anil","Patil",45000);

Console.WriteLine(h1);

List<Employee> list=new List<Employee>();
bool exit=false;
while(true){
     Console.WriteLine("1.Add emp 2.Delete Emp 3.Show all emp 4.show emp by id 5.cal emp sal by id 6. 7.exit");
    int choice=int.Parse(Console.ReadLine());
   
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter your DA, tax, id, fname, lname,basicSal");
            float DA=float.Parse(Console.ReadLine());
            float tax=float.Parse(Console.ReadLine());
            int id=int.Parse(Console.ReadLine());
            string fname=Console.ReadLine();
            string lname=Console.ReadLine();
            float sal=float.Parse(Console.ReadLine());

            list.Add(new HR(DA,tax,id,fname,lname,sal));
        break;
        case 2:
            Console.WriteLine("Enter your id");
            int id1=int.Parse(Console.ReadLine());
            foreach(Employee e in list){
                if(e.getId()==id1){
                   list.Remove(e);
                }
            }
        break;
        case 3:
            foreach(Employee emp in list){
                Console.WriteLine(emp);
            }
        break;
        case 4:
            Console.WriteLine("Enter your id");
            int id2=int.Parse(Console.ReadLine());
            foreach(Employee e in list){
                if(e.getId()==id2){
                    Console.WriteLine(e);
                }
            }
        break;
        case 5:{
            Console.WriteLine("Enter your id");
            int id3 =int.Parse(Console.ReadLine());
            foreach(Employee e in list){
                if(e.getId()==id3){
                    Console.WriteLine(e.computeSal);
                }
            }
        break;
        }
        case 6:{
            Console.WriteLine("Enter your id");
            int id3 =int.Parse(Console.ReadLine());
            foreach(Employee e in list){
                if(e.getId()==id3){
                    Console.WriteLine(e.EmployeeNameAndSal);
                }
            }
        break;
        }

        case 7:
            exit=true;
        break;
    }
}























