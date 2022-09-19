using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Student student = new Student();
            ////student.SetName("Hamid");
            ////string str = student.GetName();
            ////Console.WriteLine(str);
            ////Console.WriteLine(student.GetName());

            ////student.SetAge(18);
            ////Console.WriteLine(student.GetAge());

            //student.Name = "Hamid";
            //string str = student.Name;
            //Console.WriteLine(student.Name);

            ////student.Age1 = 15;
            //student.Test = "Student Test";
            //Console.WriteLine(student.TestMethod());

            //Human human = new Human();
            //human.Test = "Test Human";
            //Console.WriteLine(human.TestMethod());

            ////student.Name = "";
            ////student.Test();
            //Developer developer = new Developer();

            //Person person = new Person("Person");
            //person.SurName = "Personzade";
            //Console.WriteLine(person.ShowInfo());

            //Doctor doctor = new Doctor("Doctor");
            //doctor.SurName = "Doctorov";
            //doctor.Experiance = "experiance";
            //Console.WriteLine(doctor.ShowInfo());

            Test test = new Test("Test");
            test.SurName = "Testov";
            test.Experiance = "Test Experiance";
            test.TestMember = 35;

            Console.WriteLine(test.ShowInfo());
        }
    }
}
