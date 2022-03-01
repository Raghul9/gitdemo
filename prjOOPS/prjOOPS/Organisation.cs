/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPS
{
    internal class Organisation
    {
        public string orgname { get; set; }

        public int orgid { get; private set; }

        public string registrationno { get; }


        string[] orglocation = { "chennai", "mumbai", "pune" };


        internal Organisation()
        {
            Console.WriteLine(" I am a default");

        }

        internal Organisation(string oname)
        {
            orgid = 1101;
            registrationno = "Org90";
            orgname = oname;
        }

        internal void Display()
        {
            Console.WriteLine("orgid:{0},orgname:{1},registrationno:{2}", orgid, orgname, registrationno);
            foreach (string loc in orglocation)
            {
                Console.WriteLine(loc);
            }
        }

    }
        class CompanyInfo
        {
            static void Main()
            {
                Organisation organisation = new Organisation();

                organisation.orgname = "LTI";
                Console.WriteLine("object 1");
                organisation.Display();
                Console.WriteLine("object 2");
                Organisation o2 = new Organisation("ABC");
                o2.Display();






            }

        }
    
}
*/