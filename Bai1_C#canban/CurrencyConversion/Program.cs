using System;

namespace CurrencyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate = 23000f;
            float usd;
            Console.Write("Enter USD: ");
            usd = float.Parse(Console.ReadLine());
            Console.WriteLine("VND is: " + (rate * usd));
        }
    }
}
