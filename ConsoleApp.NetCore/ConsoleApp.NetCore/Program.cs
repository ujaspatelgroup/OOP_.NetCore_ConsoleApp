using System;
using System.Collections.Generic;

namespace ConsoleApp.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("105 Charlton Avenue", "Unit 1234", "Hamilton");

            List<Student> studentsList = new List<Student>();

            studentsList.Add(new Student("Steve", address, "Steve@gmail.com"));

            studentsList.Add(new Student("Ram", address, "Ram@gmail.com"));

            studentsList.Add(new Student("Abdul", address, "Abdul@gmail.com"));

            List<Staff> staffsList = new List<Staff>();

            staffsList.Add(new Staff("Sourabh", address, "Sourabh@gmail.com", 100, Convert.ToDateTime("2014-02-08 00:00:0.00"), designation.Clerk));

            staffsList.Add(new Staff("Shaili", address, "Shaili@gmail.com", 200, Convert.ToDateTime("2014-02-08 00:00:0.00"), designation.OfficeAssistance));

            staffsList.Add(new Staff("Saloni", address, "Saloni@gmail.com", 300, Convert.ToDateTime("2014-02-08 00:00:0.00"), designation.Clerk));

            List<Professor> professorsList = new List<Professor>();

            professorsList.Add(new Professor("Ravan", address, "Ravan@gmail.com", 100, Convert.ToDateTime("2014-02-08 00:00:0.00"), 40, rank.AssistProf));

            professorsList.Add(new Professor("Raja", address, "Raja@gmail.com", 200, Convert.ToDateTime("2014-02-08 00:00:0.00"), 45, rank.AssocProf));

            professorsList.Add(new Professor("Sam", address, "Sam@gmail.com", 300, Convert.ToDateTime("2014-02-08 00:00:0.00"), 49, rank.AssistProf));


            Console.WriteLine("\n ----------------------Get all Students---------------------- \n");

            foreach (var myStudent in studentsList)
            {
                Console.WriteLine(myStudent.ToString());
            }

            Console.WriteLine("\n ----------------------Get all Professors---------------------- \n");

            foreach (var professor in professorsList)
            {
                Console.WriteLine(professor.ToString());
            }

            Console.WriteLine("\n ----------------------Get all Staff---------------------- \n");

            foreach (var staff in staffsList)
            {
                Console.WriteLine(staff.ToString());
            }

            Console.WriteLine("\n ----------------------Update Steve to Ujas in Student List---------------------- \n");

            int student = studentsList.FindIndex(x => x.Name.Equals("Steve"));
            studentsList[student] = new Student("Ujas", address, "Ujas@gmail.com");

            foreach (var item in studentsList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n ----------------------Remove Ujas---------------------- \n");

            studentsList.RemoveAt(student);

            foreach (var item in studentsList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
