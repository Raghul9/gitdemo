using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Sample<T>
    {
        int m = 89; float m1 = 99.9f;
        public T mark1;
        public T mark2;

        internal void Add<T>(T x, T y)
        {
            if (x.Equals(y))
                Console.WriteLine(x + " " + y);
            else
                Console.WriteLine("not equal");
        }
        internal void Test()
        {
            if (mark1 != null & mark2 != null)
                Console.WriteLine(mark1 + " " + mark2);
        }
    }
    class Generic1
    {
        static void Main()
        {
            Sample<int> sample = new Sample<int>();
            sample.mark1 = 76;


            Sample<float> sample1 = new Sample<float>();
            sample.mark2 = 56;


            sample.Add<int>(8, 8);
            sample.Add<string>("hi", "all");

        }
    }
}




















    
   

