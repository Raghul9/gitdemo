using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConcepts
{
    internal class ExceptionHandling
    {

        static void Main()
        {
            float salary, perdaysalary;
            string[] chooselocation = { "chennai", "Bangalore", "Mumbai" };
            try
            {
                Console.WriteLine("Enter your salary");
                salary = float.Parse(Console.ReadLine());
                perdaysalary = salary / 30;
                Console.WriteLine("perdaysalary:{ 0}",perdaysalary);
                Console.WriteLine(chooselocation [3]);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Please choose the correct index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("close all port");
            }











        }
    }
}
