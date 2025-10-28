using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace CSharp_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ways to create string 

            char[] chars = { 'k', 'o', 'm', 'a', 'l' };
            string str = new string(chars);

            Console.WriteLine(str);

            String sp = "kidheud";
            Console.WriteLine(sp);

            // Create a string using a property or a method
            String s = "Geeks For Geeks";
            

            int start = s.IndexOf(" ")+1;
            int end = s.IndexOf(" ", start)-start;
            Console.WriteLine(end);
            Console.WriteLine(start);
            string str4 = s.Substring(start, end);
            Console.WriteLine("Method 4: " + str4);


            string myString = "   Hello World!   ";
            string trimmedString = myString.Trim();
            Console.WriteLine($"'{trimmedString}'"); // Output: 'Hello World!'

            string name = "  jee  ";
            string ng = name;
            Console.WriteLine(ng); //output :->  jee
            string je=ng.Replace("e", "t");
            Console.WriteLine(je);

            Console.ReadKey();
        }
    }
}
