using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public static class Extensions
    {
        /// <summary>
        /// Convert to int, default 0
        /// </summary>
        /// <param name="source">String to convert to int</param>
        /// <returns></returns>
        public static int ToInt(this string source)
        {
            Int32 output;
            var test = Int32.TryParse(source, out output);
            return test ? output : 0;
        }
        /// <summary>
        /// Convert a string to a List of strings with length of 1.
        /// </summary>
        /// <param name="source">String to use to build list</param>
        /// <returns></returns>
        public static List<string> StringToList(this string source)
            {
            var list = new List<string>();
            for (int i = 0; i< source.Length; i++)
            {
                list.Add(source.Substring(i, 1));
            }
            return list;
        }

    }
}
