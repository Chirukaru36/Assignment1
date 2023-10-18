using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringConcatenationLibrary;

namespace Assignment1
{
    public  class Program

    {

        static void Main(string[] args)
        {
            A a = new A();
            AttachStringToEachother attachDelagate =a.ConcatStrings;
            string result = attachDelagate("hello", "world");
            Console.WriteLine(result);

            Console.ReadLine();
        }

        
    }
}
