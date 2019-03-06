using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class CheckDigits
    {
        /// <summary>
        /// Check for matches between the challenge digits and the trail digits.
        /// </summary>
        /// <param name="matchTrail">Trail digits to match</param>
        /// <param name="digits">Challenge digits</param>
        /// <returns></returns>
        public static string Check(string matchTrail, List<Digit> digits)
        {
            var matchList = matchTrail.StringToList();
            var sb = new StringBuilder();
            for (int i = 0; i < digits.Count; i++) // check each digit for a matching value in the correct position.
            {
                digits[i].Matched = (digits[i].DigitValue == matchList[i]);
                if (digits[i].Matched) sb.Append("+");
            }
            for (int i = 0; i < digits.Count; i++) // check each digit for a matching value in a different position.
            {
                if (!digits[i].Matched)// if digit was not a positional match
                {
                    if (digits.Where(w => !w.Matched && w.DigitValue == matchList[i]).Any())
                    { sb.Append("-"); }
                }
            }
            return sb.ToString();
        }
    }
}
