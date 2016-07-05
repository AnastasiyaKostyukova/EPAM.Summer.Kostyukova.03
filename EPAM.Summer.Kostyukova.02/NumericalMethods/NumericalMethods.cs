using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
    /// <summary>
    /// This class contains the implementation of numerical methods, such as Euclidean Algorithm for
    /// calculation the Greatest Common Divider (GCD), Stein's algorithm (Binary GCD Algorithm) and
    /// Newton's method.
    /// </summary>
    public class NumericalMethods
    {
        #region EuclideanAlgorithmGCD

        /// <summary>Method calculates GCD of two numbers</summary>
        /// <exception cref="ArgumentException">
        /// Throws an exception when first and second number equals 0. In really result is positive infinity
        /// </exception>
        /// <param name="first">First number</param>
        /// <param name="second">Second number</param>
        /// <returns>GCD of the first and the second numbers</returns>

        public static int EuclideanAlgorithmGCD(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                throw new ArgumentException("value shoud be not equal zero!");
            }
            if (first == 0 || first == second)
            {
                return Math.Abs((int)second);
            }
            if (second == 0)
                return Math.Abs(first);

            if (second > first)
            {
                int shaker = first;
                first = second;
                second = shaker;
            }

            while (first % second != 0)
            {
                int tempNumber = first;
                first = second;
                second = tempNumber % second;
            }

            return second;
        }


        /// <summary>
        /// Implements EuclideanAlgorithmGCD <see cref="EuclideanAlgorithmGCD(int, int)"/> and calculate elapsed time
        /// </summary>
        /// <param name="elapsedTimeMilliSecs">out param for elapsed time in millisecs</param>
        /// <returns>GCD of the first and the second numbers</returns>
        public static int EuclideanAlgorithmGCD(int first, int second, out long elapsedTimeMilliSecs)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int resultGCD = EuclideanAlgorithmGCD(first, second);

            stopWatch.Stop();
            elapsedTimeMilliSecs = stopWatch.ElapsedMilliseconds;

            return resultGCD;
        }


        public static int EuclideanAlgorithmGCD(int first, int second, int third)
        {
            int tempGCD = EuclideanAlgorithmGCD(first, second);
            int resultGCD = EuclideanAlgorithmGCD(tempGCD, third);

            return resultGCD;
        }


        public static int EuclideanAlgorithmGCD(int first, int second, int third, out long elapsedTimeMilliSecs)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int resultGCD = EuclideanAlgorithmGCD(first, second, third);

            stopWatch.Stop();
            elapsedTimeMilliSecs = stopWatch.ElapsedMilliseconds;

            return resultGCD;
        }


        /// <exception cref="ArgumentException">Throws when getting 1 or 0 params</exception>
        /// <param name="arrayOfNumbers">Array of numbers can be 0, 1, 4+ length</param>
        public static int EuclideanAlgorithmGCD(params int[] arrayOfNumbers)
        {
            if (arrayOfNumbers.Length < 2)
            {
                throw new ArgumentException();
            }                

            int tempGCD = arrayOfNumbers[0];
            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                tempGCD = EuclideanAlgorithmGCD(arrayOfNumbers[i], tempGCD);
            }

            return tempGCD;
        }


        public static int EuclideanAlgorithmGCD(out long elapsedTimeMilliSecs, params int[] arrayOfNumbers)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int resultGCD = EuclideanAlgorithmGCD(arrayOfNumbers);

            stopWatch.Stop();
            elapsedTimeMilliSecs = stopWatch.ElapsedMilliseconds;

            return resultGCD;
        }
        #endregion

        #region Stein'sAlgorithmGCD(BinaryAlgorithmGCD)



        #endregion

    }
}
