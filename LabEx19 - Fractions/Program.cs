using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabEx19___Fractions
{
    class Program
    {
        /// <summary>
        /// User inputs two fraction, program returns the results of adding, subtracting, multiplying and dividing
        /// in reduced format.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two fractions in the format 1 2 2 3 - for 1/2 and 2/3");
            Console.WriteLine("Enter # to stop");
            string input = Console.ReadLine();
            while (input != "#")
            {
                string[] inputArr = input.Split(' ');
                Fraction f1 = new Fraction(int.Parse(inputArr[0]), int.Parse(inputArr[1]));
                Fraction f2 = new Fraction(int.Parse(inputArr[2]), int.Parse(inputArr[3]));
                Console.WriteLine("{0} + {1} = {2}",f1, f2, f1 + f2);
                Console.WriteLine("{0} - {1} = {2}", f1, f2, f1 - f2);
                Console.WriteLine("{0} * {1} = {2}", f1, f2, f1 * f2);
                Console.WriteLine("{0} / {1} = {2}", f1, f2, f1 / f2);
                input = Console.ReadLine();
            }

        }//main

       
    }
}
