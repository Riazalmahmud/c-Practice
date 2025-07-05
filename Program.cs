using System;
namespace TestEncapsulationspace
{

    class Person
    {
        private string name;
        public void setName(string NewName)
        {
            if (!string.IsNullOrEmpty(NewName))
            {
                name = NewName;
            }
            else
            {
                Console.WriteLine("Name cannot be empty.");
            }
        }

        public string GetName()
        {
            return name;
        }
    }


    class EmployeeSalary
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 3000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine($"salary is lase then  {value}");
                }
            }
        }

        class TestEncapsulation
        {


            static void Main(string[] args)
            {

                Person person = new Person();
                person.setName("Riaz al mahmud");
                Console.WriteLine("get person name " + person.GetName());

                // encapsulation 
                EmployeeSalary employeeSalary = new EmployeeSalary();
                employeeSalary.Salary = 50000;
                Console.WriteLine($"employeeSalary is {employeeSalary.Salary}");
                EmployeeSalary employeeSalary2 = new EmployeeSalary();
                employeeSalary2.Salary = 1000;
                Console.WriteLine($"employeeSalary is : {employeeSalary2.Salary}");


            }
        }
    }
}
