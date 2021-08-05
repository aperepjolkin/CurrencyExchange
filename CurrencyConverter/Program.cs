using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputString; 
            Console.WriteLine("Usage: Exchange <currency pair> <amout to exchage>");
            userInputString = Console.ReadLine();
            Console.WriteLine("\n");

            //
            // Calculate and display the currency exchange 
            //
            CurrencyCalculator calculator = new CurrencyCalculator();
            float exchangeRate = calculator.Exchange(userInputString);
        }
    }
}
