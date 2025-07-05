using System;
namespace TestDataTypeNamespace
{


    struct Employee
    {
        public double selary;
        public double Id;

}

    class TestDataType
    {

        enum JobLevel { Intern, Junior, Mid, Senior, Manager }
        enum UserType { user, manager, marketing, superAdmin }

        static void MainData(string[] args)
        {
            float gpa = 3.85f;
            double distance = 384400.5;
            decimal accountBalance = 15249.75m;
            Console.WriteLine("Student GPA: " + gpa);
            Console.WriteLine("Distance to Moon (km): " + distance);
            Console.WriteLine("Bank Account Balance: $" + accountBalance);
            Console.WriteLine("enum: $" + JobLevel.Intern);
            Console.WriteLine("enum: $" + UserType.manager);

            Employee em;
            Object obj = 50000;
            em.selary = 5000;

            dynamic dynamic = 10;
            Console.WriteLine("object is : $" + obj);
            Console.WriteLine("dynamic object is : $" + dynamic);

            string[] student = { "Abul", "Babul", "Cabul", "Dabul" };
            foreach (string st in student)
            {
                Console.WriteLine("Student name: " + st);
            }

        }
    }
}
