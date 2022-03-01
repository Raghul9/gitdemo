using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPS
{
    internal class Student
    {

        public string Sname { get; set; }

        public string Dept { get; set; }

        //static variable

        public static string collegename;

        //static constructor

        static Student()
        {
            Console.WriteLine("static constructor");
            collegename = "MIT";

        }
        internal Student(string Sname, string Dept)
        {
            this.Sname = Sname;
            this.Dept = Dept;
        }
        internal void PrintData()
        {
            Console.WriteLine("sname:{0},Dept:{1},collegename:{2}", Sname, Dept, collegename);
        }

        internal static float studentAverage(int total, int noofstudents)
        {
            float Average = total / noofstudents;

            return Average;
        }




    }
    internal class StaticEg
    {

        public static void Main()
        {
            Student student = new Student("raghul", "ece");
            student.PrintData();

            Student student1 = new Student("Ravi", " mech");
            student1.PrintData();

            Student student2 = new Student("Rajesh", "eee");
            student2.PrintData();

            Student.studentAverage(500, 5);
            Student.studentAverage = Convert.ToInt32(Student.studentAverage);
            

            //array od
            Console.WriteLine("Enter the no of students");
            int n=Convert.ToInt32(Console.ReadLine());
            string stuname, studept;
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name");
                stuname =Console.ReadLine();
                Console.WriteLine("Enter dept");
                studept =Console.ReadLine();
                students[i] = new Student(stuname, studept);

            }
            for (int i = 0; i < n; i++)
            {
                students[i].PrintData();




                Console.Read();
            }
        }

    }
}

