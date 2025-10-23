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
            int[] intArray3 = { 1, 2, 3, 4, 5 };//valid

            // int[] newArray2 = new int[] ;//compile time error

            string[] str1;
            //str1 = {"Element 1", "Element 1"}; //Error : wrong initialization of an array 

            Console.Write("For loop :");
            for (int i = 0; i < intArray3.Length; i++)
            {
                Console.Write(" "+intArray3[i]);
            }
            Console.WriteLine();

            //------------------------
            Console.Write("foreach loop :");
            foreach (int elements in intArray3)
            {
                Console.Write(" "+elements);
            }
            Console.WriteLine();

            //----------------------
            Console.Write("while loop :");
            int j = 0;
            while (j < intArray3.Length)
            {
                Console.Write(" " + intArray3[j]);
                j++;
            }
            Console.WriteLine();

            //----------------------
            Console.Write("do while loop :");
            int k = 0;
            do
            {
                Console.Write(" " + intArray3[k]);
                k++;
            }
            while(k< intArray3.Length);

            Console.ReadKey();
        }
    }
}
