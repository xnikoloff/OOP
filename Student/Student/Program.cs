using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Student that contains the following info:
            //Three names, Course, Degree, University, Email, Phone

            Student student1 = new Student("Richard", "Williams", "rich.will@gmail.com");

            student1.PrintInfo();
        }
    }
}
