using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempMan
{
    class Program
    {

        private static bool uiMode = false;

        static void Main(string[] args)
        {
            args = new string[] { "32", "-F" };
            string[] converts = ConvertAll(ProcessArguments(args));

            if (uiMode)
            {

            }
            else
            {
                printConversionSummary(args[0] + args[1].Replace("-", ""), converts);
            }
        }


        private static string[] ConvertAll(double kelvin)
        {
            string[] convertedTemps = {
                                        "Fahrenheit-" + ConvertToFahrenheit(kelvin),
                                        "Celsius-" + ConvertToCelsius(kelvin),
                                        "Kelvin-" + ConvertToKevin(kelvin),
                                        "Romer-" + ConvertToRomer(kelvin),
                                        "Reaumur-" + ConvertToReaumur(kelvin),
                                        "Newton-" + ConvertToNewton(kelvin),
                                        "Rankine-" + ConvertToRankine(kelvin),
                                        "Delisle-" + ConvertToDelisle(kelvin)
                                     };
            return convertedTemps;
        }

        private static double ProcessArguments(string[] args)
        {
            double unKnown = double.Parse(args[0]);
            double kelvin = 0;

            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "-F":
                        kelvin = ConvertFromFahrenheit(unKnown);
                        break;
                    case "-C":
                        kelvin = ConvertFromCelsius(unKnown);
                        break;
                    case "-K":
                        kelvin = unKnown;
                        break;
                    case "-Ro":
                        kelvin = ConvertFromRomer(unKnown);
                        break;
                    case "-Re":
                        kelvin = ConvertFromReaumur(unKnown);
                        break;
                    case "-N":
                        kelvin = ConvertFromNewton(unKnown);
                        break;
                    case "-R":
                        kelvin = ConvertFromRankine(unKnown);
                        break;
                    case "-De":
                        kelvin = ConvertFromDelisle(unKnown);
                        break;
                    case "-to":
                        break;
                    case "-RandCon":
                        break;
                    case "-Out":
                        break;
                    case "-Ui":
                        uiMode = true;
                        break;
                }
            }

            return kelvin;
        }

        private static void printConversionSummary(string orignalTemp, string[] convertedTemps)
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"units for {orignalTemp}:");

            foreach (string temp in convertedTemps)
            {
                printConversion(temp.Split('-'));
            }
            Console.WriteLine("=============================");
        }

        private static void printConversion(string[] unitValue)
        {
            Console.WriteLine($"{unitValue[0]}:\t\t{unitValue[1]}");
        }

        /////////////////////////////////////////////////////////
        //Converting from Kelvin
        /////////////////////////////////////////////////////////
        private static string ConvertToFahrenheit(double kelvin)
        {
            return kelvin * (9 / 5) - 459.67 + "F";
        }

        private static string ConvertToCelsius(double kelvin)
        {
            return kelvin - 273.15 + "C";
        }

        private static string ConvertToRomer(double kelvin)
        {
            return (kelvin - 273.15) * (21 / 40) + 7.5 + "Ro";
        }

        private static string ConvertToReaumur(double kelvin)
        {
            return (kelvin - 273.15) * (9 / 5) + "Re";
        }

        private static string ConvertToNewton(double kelvin)
        {
            return (kelvin - 273.15) * (33 / 100) + "N";
        }

        private static string ConvertToRankine(double kelvin)
        {
            return kelvin * (9 / 5) + "R";
        }

        private static string ConvertToDelisle(double kelvin)
        {
            return (373.15 - kelvin) * (3 / 2) + "De";
        }

        private static string ConvertToKevin(double kelvin)
        {
            return kelvin + "K";
        }

        /////////////////////////////////////////////////////////
        //Converting to Kelvin
        /////////////////////////////////////////////////////////
        private static double ConvertFromFahrenheit(double fahrenheit)
        {
            return (fahrenheit + 459.67) * (5 / 9);
        }

        private static double ConvertFromCelsius(double celsius)
        {
            return celsius + 273.15;
        }

        private static double ConvertFromRomer(double romer)
        {
            return (romer - 7.5) * (40 / 21) + 273.15;
        }

        private static double ConvertFromReaumur(double reaumur)
        {
            return reaumur * 1.25 + 273.15;
        }

        private static double ConvertFromNewton(double newton)
        {
            return newton * (100 / 33) + 273.15;
        }

        private static double ConvertFromRankine(double rankine)
        {
            return rankine / 1.8;
        }

        private static double ConvertFromDelisle(double delisle)
        {
            return 373.15 - (delisle * (2 / 3));
        }
    }
}
