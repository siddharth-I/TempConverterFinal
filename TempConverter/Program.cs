using System;

namespace TempConverter
{
    class Program
    {
        public static void RunCode()
        {
            Console.WriteLine("Welcome to the Temperature Converter!");
            Console.WriteLine("What is the temperature?");
            string stringInput = (Console.ReadLine());
            decimal decimalInput = System.Convert.ToDecimal(stringInput);
            Console.WriteLine("What unit is that? (F = Fahrenheit, C = Celsius).");
            string tempInput = Console.ReadLine();
            if (tempInput.StartsWith("F", StringComparison.OrdinalIgnoreCase))
            {
                decimal tempCelsius = (decimalInput - 32) * 5 / 9;
                decimal roundTempCelsius = Math.Round(tempCelsius, 1);
                Console.WriteLine($"{decimalInput} degrees Fahrenheit is {roundTempCelsius} degrees Celsius.");
                if (tempCelsius >= 26.7m)
                {
                    Console.WriteLine("That's really warm!");
                }
            }
            else if (tempInput.StartsWith("C", StringComparison.OrdinalIgnoreCase))
            {
                decimal tempFahrenheit = decimalInput * 9 / 5 + 32;
                decimal roundTempFahrenheit = Math.Round(tempFahrenheit, 1);
                Console.WriteLine($"{decimalInput} degrees Celsius is {roundTempFahrenheit} degrees Fahrenheit.");
                if (tempFahrenheit >= 80.0m)
                {
                    Console.WriteLine("That's really warm!");
                }
            }
        }
        static void Main(string[] args)
        {
            bool runAgain = true;

            while (runAgain == true)
            {
                RunCode();
                Console.WriteLine("Would you like to convert another temperature? Answer only True or False");
                string inputContinue = Console.ReadLine();
                Boolean boolContinue;

                if (Boolean.TryParse(inputContinue, out boolContinue))
                if (boolContinue == true)
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}
