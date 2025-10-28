using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace CSharp_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Using string ---
            string str = "Hello";
            str += " World"; // Creates a NEW string each time we modify it
            Console.WriteLine("String: " + str);

            // --- Using StringBuilder ---
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World"); // Modifies the same object (no new copy)
            Console.WriteLine("StringBuilder: " + sb);

            // --- Demonstration of immutability ---
            string str1 = "Hello";
            string str2 = str1;
            str1 += " World";
            Console.WriteLine("\nString immutability check:");
            Console.WriteLine("str1 = " + str1);
            Console.WriteLine("str2 = " + str2);

            // --- Demonstration of mutability ---
            StringBuilder sb1 = new StringBuilder("Hello");
            StringBuilder sb2 = sb1;
            sb1.Append(" World");
            Console.WriteLine("\nStringBuilder mutability check:");
            Console.WriteLine("sb1 = " + sb1);
            Console.WriteLine("sb2 = " + sb2);


            Console.ReadKey();
        }
    }
}

