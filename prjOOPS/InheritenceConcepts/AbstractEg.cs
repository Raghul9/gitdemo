/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConcepts

{
    abstract class Rbi
    {
        public int noofbanksundercontrol { get; set; }


        abstract public int HomeLoan();//abstract

        internal string Rules()
        {
            return "pancard is mandatory for all customer";

        }
    }
    class Sbi:Rbi
    {
        public override int HomeLoan()
        {
            Console.WriteLine("To apply HomeLoan read the following details: 1.aadhar 2.pan card");
            return 10 ;
        }
    }

    class Icici : Rbi
    {
        public override int HomeLoan()
        {
            Console.WriteLine("Icici Home percentage :");
            return 9;
        }
    }
    internal class AbstractEg
    {
        static void Main()
        {// run time polymorphism
            Rbi robj;

            robj=new Sbi();
            Console.WriteLine(robj.HomeLoan());
            robj = new Icici();
            Console.WriteLine(robj.HomeLoan());
        }


    }
}*/
