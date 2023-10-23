using System;
namespace exercise01
{
    enum Department
    {
        ComputerScience,
        ElectricalEngineering,
        MechanicalEngineering,
        CivilEngineering,
        BusinessAdministration
    }
    class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = null;
        }

        public Person(string name)
        {
            Name = name;
        }
    }


    class Student : Person
    {
        public string RegNo { get; set; }
        public int Age { get; set; }
        public Department Program { get; set; }

        public Student()
        {
            RegNo = null;
            Age = 0;
            Program = Department.ComputerScience;
        }

        public Student(string name, string regNo, int age, Department program)
            : base(name)
        {
            RegNo = regNo;
            Age = age;
            Program = program;
        }
    }

    class Program
    {
        static void Main()
        {

            Student student1 = new Student("John Doe", "12345", 20, Department.BusinessAdministration);
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Registration Number: " + student1.RegNo);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Program: " + student1.Program);
        }
    }
}
