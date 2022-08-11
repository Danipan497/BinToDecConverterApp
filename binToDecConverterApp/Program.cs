using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2DecConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||||This is a simple binary to decimal converter.|||| \n\nPlease enter binary number to continue...\n");

            string input = Console.ReadLine();

            string zeroCondition = "0";
            string oneCondition = "1";
            bool consistZero = input.Contains(zeroCondition);
            bool consistOne = input.Contains(oneCondition);
            int inputLenght = input.Length;

            try
            {
                if (inputLenght > 8)
                {
                    Console.WriteLine("Entered value is longer than 8 digits.");
                }
                else if (consistZero && consistOne)
                {
                    int convert = Convert.ToInt32(input, 2);
                    Console.WriteLine($"\nYou have passed {input} in binary system. \n\nOutput in decimal system: {convert}.\n");
                }
                else
                {
                    Console.WriteLine("Entered value in not binary value!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Parameter index cannot be diffrent than 0 or 1.");
            }
        }
    }
}


