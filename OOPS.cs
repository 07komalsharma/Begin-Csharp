using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Learning
{
    internal class Program
    {
        // ABSTRACTION — common interface for all payment types
        public abstract class Payment
        {
            public abstract bool ProcessPayment(decimal amount); // without implementation 
            
        }

        // INHERITANCE — different payment methods inherit Payment
        public class CreditCardPay : Payment
        {
            public override bool ProcessPayment(decimal amount)
            {
                Console.WriteLine($"paid via credit card {amount} ");
                return true;
            }
        }
        public class UPIPayment : Payment
        {
            public override bool ProcessPayment(decimal amount)
            {
                Console.WriteLine($"paid via upi - digital {amount} ");
                return true;
            }
        }

        // POLYMORPHISM — runtime behavior changes based on payment type

        public class PaymentService
        {
            public void MakePayment(Payment payment, decimal amount)
            {
                payment.ProcessPayment(amount);
            }
        }
        static void Main(string[] args)
        {
            PaymentService service = new PaymentService();
            service.MakePayment(new CreditCardPay(), 1000);
            service.MakePayment(new  UPIPayment(), 5000);
            Console.ReadKey();

        }
    }
}
