using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class Functions
    {
        /// <summary>
        /// Obtain a random int between 0 and the max range
        /// </summary>
        /// <param name="maxRange">Largest possible number in range.</param>
        /// <returns></returns>
        public static int Randomized(int maxRange) => new Random(Guid.NewGuid().GetHashCode()).Next(1, maxRange + 1);
        /// <summary>
        /// Build a list of digits.
        /// </summary>
        /// <param name="numberDigits">Length of list to retrun</param>
        /// <param name="maxValue">Maximum integer value for each digit.</param>
        /// <returns></returns>
        public static List<Digit> BuildDigits(int numberDigits, int maxValue)
        {
            var returnValue = new List<Digit>();
            for (int i = 0; i < numberDigits; i++)
            {
                returnValue.Add(new Digit { DigitValue = Randomized(maxValue).ToString() });
            }
            return returnValue;
        }
    }
}
