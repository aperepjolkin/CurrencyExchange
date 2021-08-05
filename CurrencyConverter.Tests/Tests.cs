using System;
using System.Collections.Generic;
using Xunit;

namespace CurrencyConverter.Tests
{
    public class Tests
    {

        [Fact]
        public void Exchange_ISO_Currency_EURDKK_Pair_AmountOneEur()
        {
            // Assign
            string userInput = "Exchange EUR/DKK 1";
            CurrencyCalculator calc = new CurrencyCalculator();
            // Act
            float exchangedAmount = calc.Exchange(userInput);
            // Assert
            Assert.Equal(Math.Round(7.4394, 4), exchangedAmount, 4);
        }

        [Theory]
        [InlineData("Exchange EUR/DKK 100", 743.94F)]
        [InlineData("Exchange USD/DKK 100", 663.11F)]
        [InlineData("Exchange GBP/DKK 100", 852.85F)]
        [InlineData("Exchange SEK/DKK 100", 76.10F)]
        [InlineData("Exchange NOK/DKK 100", 78.40F)]
        [InlineData("Exchange CHF/DKK 100", 683.53F)]
        [InlineData("Exchange JPY/DKK 100", 5.9740F)]
        public void Purchase_ISO_Pair_One_Hundred_In_Any_Currency(string currencyPurchaseInput, float amount)
        {
            // Assign
            CurrencyCalculator calc = new CurrencyCalculator();
            // Act
            float exchangedAmount = calc.Exchange(currencyPurchaseInput);

            // Assert
            Assert.Equal(Math.Round(amount, 4), exchangedAmount, 4);
        }

        
    }
}
