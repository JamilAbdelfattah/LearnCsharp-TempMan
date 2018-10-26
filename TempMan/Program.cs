using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * I know this seems a bit hard, but give it a try and if you get stuck let me know,
 * Its really not that bad, but you need to learn not to get scared, this project isn't hard its just seems like it.
 * 
 * But I hope you have fun, and write something you're proud of. We'll continue to expland on this so keep that in mind.
 * So as a note don't worry about having other 'classes (files) we'll do that later right now just do you solution in this class.
 * 
 * Things to note, the main method is the starting point of every application, everything has one, discord does, and visualstudio does too!
 * If you get stuck, an important skill to learn is unblocking yourself, and you can't learn it if you don't get stuck.
 * Don't feel stupid or dumb, everyone gets stuck on something stupid, it happened to me today... named my main method at work with a 
 * capital M and in Java its suppose to be lowercase, spent 3 hours trying to figure it out. it happens...
 * 
 * Also a switch statement would be REALLY helpful for processing the arguments. don't worry about getting every feature just start with the basics
 * start with handling only one arg at a time.
 * */

namespace TempMan
{
    class Program
    {
        //args are the values after tempman.exe, such as 32 -f -out c:/
        static void Main(string[] args)
        {
        }

        /**
         * This is a bad way of doing this but, I need you to be comfortable with arrays, 
         * and the best way I know how to do that is to do it the dumb hard way.
         * but your array should look like that gets passed into this function should be like...
         * 
         * if the command args were tempman.exe 32 -f
         * [32F, Celsius-29C, Kelvin-29K, Romer-60Ro, Reaumur-80Re, ...]
         * 
         * Do not include Fahrenheit except for the first element just like it appears,
         * 
         * if it was tempman.exe 32 -c that was passed in your array should be
         * [32C, Fahrenheit-29F, Kelvin-29K, Romer-60Ro, Reaumur-80Re, ...]
         * 
         * */
        private static void printConversionSummary(string[] convertedTemps)
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"units for {convertedTemps[0]}:");
            foreach(string temp in convertedTemps)
            {
                printConversion(temp.Split('-'));
            }
            Console.WriteLine("=============================");
        }

        private static void printConversion(string[] unitValue)
        {
            Console.WriteLine($"{unitValue[0]}:\t\t{unitValue[1]}");
        }
    }
}
