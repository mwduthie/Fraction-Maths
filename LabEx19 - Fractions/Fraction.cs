using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx19___Fractions
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public int Denominator
        {
            get { return denominator; }
            private set { denominator = value; }
        }

        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        #region Operator Overloads
        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            int newNumerator = (f1.Numerator * f2.Denominator) + (f1.Denominator * f2.Numerator);
            int newDenominator = f1.Denominator * f2.Denominator;
            Fraction newFraction =  new Fraction(newNumerator, newDenominator);
            return Reduce(newFraction);
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            int newNumerator = (f1.Numerator * f2.Denominator) - (f1.Denominator * f2.Numerator);
            int newDenominator = f1.Denominator * f2.Denominator;
            Fraction newFraction = new Fraction(newNumerator, newDenominator);
            return Reduce(newFraction);
        }

        public static Fraction operator * (Fraction f1, Fraction f2)
        {
            int newNumerator = f1.Numerator * f2.Numerator;
            int newDenominator = f1.Denominator * f2.Denominator;
            Fraction newFraction = new Fraction(newNumerator, newDenominator);
            return Reduce(newFraction);
        }

        public static Fraction operator / (Fraction f1, Fraction f2)
        {
            int newNumerator = f1.Numerator * f2.Denominator;
            int newDenominator = f1.Denominator * f2.Numerator;
            Fraction newFraction = new Fraction(newNumerator, newDenominator);
            return Reduce(newFraction);
        }

        #endregion


        /// <summary>
        /// Reduces the fraction to its smallest possible size, eg 12/24 -> 1/2
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns></returns>
        public static Fraction Reduce(Fraction fraction)
        {
            //Returns the Greatest Common Divisor of the numerator and denominator
            //Console.WriteLine("Initial Fraction: " + fraction);
            int theGCD = (int) Gcd(fraction.Numerator, fraction.Denominator);
            //Console.WriteLine("Reduced fraction: " + new Fraction(fraction.Numerator / theGCD, fraction.Denominator / theGCD));
            return new Fraction(fraction.Numerator/theGCD, fraction.Denominator/theGCD);
        }

        /// <summary>
        /// Recursive function to find the greatest common divisor, 
        /// </summary>
        /// <param name="num">The numerator, when called recursively becomes the previous denominator</param>
        /// <param name="denom">The denominator, when called recursively becomes the remainder
        /// of previous denominator/numerator</param>
        /// <returns></returns>
        static double Gcd(double num, double denom)
        {
            //Get's the remainder of denominator / numerator
            double remain = denom % num;
            if (remain == 0)
            {
                //because num was going to be the denominator in the next loop, which would = 0;
                return num; 
            }
            //Recursive call of Gcd
            return Gcd(remain, num);
        }
    }
}
