using System;


namespace Inheritence
{
    class Program

    {
       
        static void Main()
        {
            //PermaEmployee Abhi = new PermaEmployee();
            //Abhi.ID = 1;
            

            //TempEmployee Manu = new TempEmployee();
            //Manu.ID = 2;
            //Abhi.Show();

            //Console.WriteLine(Abhi.ID);
            //Console.WriteLine(Manu.ID);
        
            //Console.ReadLine();




            //Person p = new Person();
            //p.setName("Abhishek Sharma");
            //p.getName();
            //p.setAge(26);
            //p.getAge();
            
            //Console.ReadLine();




            Child c = new Child();
            c.Show();
            Console.ReadLine();

            ((Parent)c).Show();
            Console.ReadLine() ;

            Parent z = new Child();
            z.Show();
            Console.ReadLine() ;

        }
    }

    //class TempEmployee : Employee
    //{
       
    //    public int TempEmpSalary;
    //    public int VisitingHour;
    //}

    //class PermaEmployee : Employee
    //{
    //    public int PermaEmpSalary;
    //    public int PermanentHour;
    //}
    //class Employee
    //{
    //    public int ID;
    //    public string? EmpName;
    //    public int EmpAge;
    //    public int EmpContactNo;

    //    public void Show()
    //    {
    //        Console.WriteLine("This a Method of Base Class");
    //    }
    //}

    class Person 
    
    { 
        private int Age;
        private string? Name;

        public void setAge(int Age)
        {
            if(Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age Should not be Negtive or Zero");
            }
            
            
        }
        public void getAge()
        {
            if(Age > 0)
            {
                Console.WriteLine("Your Age is : " + this.Age);
            }
            else
            {

            }
           
        } 

        public void setName(string? Name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.Name = Name;
            }
            
        }
        public void getName()
        {
            if(string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your Name is : " + this.Name);
            }
            
        }
    }
}