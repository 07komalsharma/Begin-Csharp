using System;
namespace CSharp_Learning
{
    /*
     ref keyword indicates that a parameter is passed by reference and that the variable must be initialized before it is passed to the method. 
     The method can then read and modify the value of the variable, and these changes will be reflected in the original variable in the calling scope.
     --------------------------------------------------------------------------------------------------------------------------------------------------
     out keyword also indicates that a parameter is passed by reference, but unlike ref, the variable does not need to be initialized before being passed to the method. 
     However, the method must assign a value to the out parameter before it returns. This is typically used when a method needs to return multiple values. 
     
     */
    public class Program
    {
        
        public static void IncrementFun(ref int number)
        {
            number = number + 1;
            Console.WriteLine($"number value inside this Increment function : {number}");
        }

        public static void Calculate(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
            Console.WriteLine($"Inside Calculate function - Sum: {sum}, Product: {product}");
        }
        static void Main(string[] args)
        {
            int number = 3;
            Console.WriteLine($"Before Increment fun :{number}");
            IncrementFun(ref number);
            Console.WriteLine($"After Increment fun called:{number}");

            int TotalSum;
            int TotalProduct;
            Calculate(2, 3, out TotalSum, out TotalProduct);
            Console.WriteLine($"After calculate function {TotalSum} & {TotalProduct} ");
            Console.ReadKey();
        }
    }
}

