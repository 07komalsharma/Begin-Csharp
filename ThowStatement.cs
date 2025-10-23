using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharp_Learning
{
    internal class Program
    {
        static string val = null;

        public static void AnyLogic(string val1)
        {
            // Throw a NullReferenceException if the input parameter is null
            if (val1 == null)
                throw new NullReferenceException("Exception Message");
        }

        static void Main(string[] args)
        {
            try
            {
                // This will throw a NullReferenceException since 'val' is null
                AnyLogic(val);
            }
            catch (NullReferenceException ex)
            {
                // This block will catch the NullReferenceException thrown above
                Console.WriteLine("ex-1: " + ex.Message);
            }
            // This catch block will not execute because the exception is already handled in the previous block
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ex-2: " + ex.Message);
            }
            catch (Exception ex)
            {
                // This block is for handling any other types of exceptions not caught above
                Console.WriteLine("ex-3: " + ex.Message);
            }

            // Keeps the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
