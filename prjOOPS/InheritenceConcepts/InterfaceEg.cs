/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConcepts
{
    interface INormalcalculator

    {
        string calculatorname { get; set; }

        int Add(int a, int b);
        int Sub(int a, int b);


    }
    class Pixel :INormalcalculator,IScientificcalculator
    {
        public string isbn { get; set; }

        public string calculatorname { get; set; }
        int INormalcalculator.Add(int x, int y)
        {
            calculatorname = "Normalcalculator";
            Console.WriteLine(calculatorname);
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }


        int IScientificcalculator.Add(int x, int y)
        {
            calculatorname = "Scientificcalculator";
            Console.WriteLine(calculatorname);
            return x + y;
        }
    }
        class InterfaceEg
         {

            static void Main()
            {
             INormalcalculator normalcalculator = new Pixel();
            int c = normalcalculator.Add(6, 5);
            Console.WriteLine("normal",c);
            Console.WriteLine("Sub method:{ 0}",normalcalculator.Sub(7,2));
            IScientificcalculator Scientificcalculator = new Pixel();
            Console.WriteLine("scientific add is ;{0}",Scientificcalculator.Add(8,8));
            }
         }
}*/