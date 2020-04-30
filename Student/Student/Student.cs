using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        //declair fields
        private string firstName;
        private string fathersName;
        private string lastName;
        private int course;
        private string degree;
        private string university;
        private string email;
        private string phone;
        static int studentsCount;

        public Student()
            : this(default(String), default(String), default(String))
        {
            studentsCount++;
        }

        public Student(string firstName, string lastName, string email)
            : this(firstName, default(String), lastName, default(Int32), default(String), default(String), email)
        {
            studentsCount++;
        }

        public Student(string firstName, string fathersName, string lastName, int course, string degree, string university, string email)
            : this(firstName, fathersName, lastName, course, degree, university, email, default(String))
        {
            studentsCount++;
        }

        public Student(string firstName, string fathersName, string lastName, int course, string degree, string university, string email, string phone)
        {
            this.firstName = firstName;
            this.fathersName = fathersName;
            this.lastName = lastName;
            this.course = course;
            this.degree = degree;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string FatherName
        {
            get { return this.fathersName; }
            set { this.fathersName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public string Degree
        {
            get { return this.degree; }
            set { this.degree = value; }
        }

        public string University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Student info: ");
            Console.WriteLine($"Name: {this.firstName}\nFather's name: {this.fathersName}\nLast name: {this.lastName}\n" +
                $"Course: {this.course}\nDegree: {this.degree}\nUniversity: {this.university}\nEmail: {this.email}\nPhone: {this.phone}");
        }

        static public void GetStudentsCount()
        {
            Console.WriteLine($"There are {studentsCount} students currently");
        }
    }
}
