using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CurrencyConverter
{

    public  class CurrencyCalculator : ICurrencyCalculator
    {

        public float Exchange(string inputStr)
        {
            List<Currency> currencyRateList = new List<Currency>();
            currencyRateList.Add(
                    new Currency { ISO = "EUR", Amount = 7.4394F });
            currencyRateList.Add(
                   new Currency { ISO = "USD", Amount = 6.6311F });
            currencyRateList.Add(
                   new Currency { ISO = "GBP", Amount = 8.5285F });
            currencyRateList.Add(
                   new Currency { ISO = "SEK", Amount = 0.761F });
            currencyRateList.Add(
                   new Currency { ISO = "NOK", Amount = 0.784F });
            currencyRateList.Add(
                   new Currency { ISO = "CHF", Amount = 6.6311F });
            currencyRateList.Add(
                   new Currency { ISO = "JPY", Amount = 0.059740F });


            string[] splitInput = inputStr?.Split(' ');
       

            var cmd = splitInput[0];
            var currencies = splitInput[1].Split('/');

            if (currencies == null)
                WriteLine("Please provide ISO pair");

            var mainCurrency = currencies[0];
            var moneyCurrency = currencies[1];
            var getCurrencyRate = currencyRateList.FirstOrDefault(rate => rate.ISO.Contains(mainCurrency)).Amount;


            var amount = (float)Convert.ToDecimal(splitInput[2]);
            var finalRate = (float)(amount * getCurrencyRate);

            WriteLine(finalRate);

            return finalRate;
        }
    }
}
