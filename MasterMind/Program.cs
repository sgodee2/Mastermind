using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Models;

namespace MasterMind
{
    class Program
    {
        const int MaxTrails = 10;
        const int NumberOfDigits = 4;
        const int MaxValueOfDigit = 6;
        const string WinningResult = "++++";
        const string StartMessage = "Type a 4 digit number with each digit having a value between 1 and 6";
        const string LostMessage = "Lost Mastermind matching.";

        static void Main(string[] args)
        {
            var Digits = Functions.BuildDigits(NumberOfDigits,MaxValueOfDigit);
            string checkResult = "";
            Console.WriteLine(StartMessage);
            for (int trailNum = 0; trailNum < MaxTrails; trailNum++)
            {
                var matchTest = Console.ReadLine();
                if (matchTest.Length > NumberOfDigits-1) // avoid error if entered string is too short.
                {
                    checkResult = CheckDigits.Check(matchTest, Digits);
                    Console.WriteLine(checkResult);
                    if (checkResult == WinningResult) break; // winner
                }
            }
            if (checkResult != WinningResult) Console.WriteLine(LostMessage);
            Console.ReadLine(); // Allow the output to be read.
        }
    }
}
