using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Models
{
    /// <summary>
    /// One digit in the challenge
    /// </summary>
    public class Digit
    {
        /// <summary>
        /// Value for this digit
        /// </summary>
        public string DigitValue { get; set; }
        /// <summary>
        ///Result of a comparison to a test value
        /// </summary>
        public Boolean Matched { get; set; }
    }
}
