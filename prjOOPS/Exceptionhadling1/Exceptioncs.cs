using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhadling1
{
    class AgeNotValid : ApplicationException
    {
        public AgeNotValid(string message) : base(message)
        {

        }
    }
    class ApplyVoterID
    {
        string status;


        public string VoterId(int age)
        {
            if (age > 18)
            {
                status = "Eligible";
            }
            else
            {
                throw new AgeNotValid("The minimum age required is 18");
            }


            return status;


        }

        internal class Exceptioncs
        {



            static void Main()
            {
                float salary, perdaysalary;
                string[] chooselocation = { "chennai", "Bangalore", "Mumbai" };
                ApplyVoterID applyVoterID = new ApplyVoterID();
                try
                {
                    Console.WriteLine("Enter your salary");
                    salary = float.Parse(Console.ReadLine());
                    perdaysalary = salary / 30;
                    Console.WriteLine("perdaysalary:{ 0}", perdaysalary);
                    //Console.WriteLine(chooselocation[3]);

                    applyVoterID.VoterId(16);
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
}