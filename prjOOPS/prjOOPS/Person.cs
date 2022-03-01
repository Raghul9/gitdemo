/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPS
{
     internal class Person
     {
        string name,city;
        int age;

        void GetData()
        {
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your city");
            city = Console.ReadLine();

            Console.WriteLine("enter the age");
            age = Convert.ToInt32(Console.ReadLine());
        }
        void PrintUserData()
        {
            Console.WriteLine("Name:{0} || City :{1}  || Age :{ 2}", name, city, age);

        }
        static void Main()
        { 
            Person p = new Person();
            p.city = "chennai";
            p.GetData();
            p.PrintUserData();
            Console.Read();

        }

     }
}
*/