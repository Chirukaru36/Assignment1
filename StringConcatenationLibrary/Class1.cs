using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenationLibrary
{
    public delegate string AttachStringToEachother(string s1 , string s2 ); 
    public class A
    {
        public string ConcatStrings(string s1,string s2)
        {
            return s1 + s2;
        }

    }
}
