using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConcepts
{
    internal class Mobile
    {
        public int isbn { get; set; }

        public virtual void Clock()
        {
            Console.WriteLine("i am method of mobile Clock");
        }


        public virtual void EyeSensor()
        {
            Console.WriteLine("Eyesensor");

        }
    }
    internal class Samsung:Mobile
    {
        public override  void Clock()
        {
            Console.WriteLine("I am world clock method of samsung Clock");
        }
        public string SamsungPay()
        {
            return "amount";
        }

        
    }
    internal class VirtualEg
    {

        static void Main()
        {

          Mobile mobile = new Mobile();
          mobile.Clock();
          mobile.EyeSensor();
          Samsung samsung = new Samsung();
          samsung.Clock();
          Console.WriteLine(samsung.SamsungPay());

        }
    }
}
