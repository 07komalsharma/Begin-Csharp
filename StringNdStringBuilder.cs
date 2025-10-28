using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace CSharp_Learning
{
    internal class Program
    {

        public static void concat1(string s1)
        {
            string st = "sharma";
            s1 = string.Concat(s1, st);
        }

        public static void concat2(StringBuilder sb)
        {
            
            sb.Append("sharma");
        }
        static void Main(string[] args)
        {
            string s1 = "komal";
            concat1(s1);
            Console.WriteLine("using string : "+ s1);

            StringBuilder str = new StringBuilder("komal");
            concat2(str);
            Console.WriteLine("Using StringBuilder Class: " +str);

            Console.ReadKey();
        }
    }
}
