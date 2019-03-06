using System;
using System.Collections.Generic;
using MasterMind;
using MasterMind.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterMindTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckMatch()
        {
            var FourDigits = new List<Digit>
            {
                new Digit { DigitValue = "4" },
                new Digit { DigitValue = "3" },
                new Digit { DigitValue = "2" },
                new Digit { DigitValue = "1" },
            };
            Assert.AreEqual("++++", CheckDigits.Check("4321", FourDigits));
        }
        [TestMethod]
        public void TestCheckMatch1()
        {
            var FourDigits = new List<Digit>
            {
                new Digit { DigitValue = "4" },
                new Digit { DigitValue = "3" },
                new Digit { DigitValue = "2" },
                new Digit { DigitValue = "1" },
            };
            Assert.AreEqual("+---", CheckDigits.Check("4213", FourDigits));
        }
        [TestMethod]
        public void TestCheckMatch11()
        {
            var FourDigits = new List<Digit>
            {
                new Digit { DigitValue = "4" },
                new Digit { DigitValue = "3" },
                new Digit { DigitValue = "2" },
                new Digit { DigitValue = "1" },
            };
            Assert.AreEqual("+-", CheckDigits.Check("4663", FourDigits));
        }
        [TestMethod]
        public void TestCheckMatchNone()
        {
            var FourDigits = new List<Digit>
            {
                new Digit { DigitValue = "4" },
                new Digit { DigitValue = "3" },
                new Digit { DigitValue = "2" },
                new Digit { DigitValue = "1" },
            };
            Assert.AreEqual("", CheckDigits.Check("5656", FourDigits));
        }
        [TestMethod]
        public void TestDigitBuild()
        {
            for(int i=0;i<1000;i++)
            {
                var Digits = Functions.BuildDigits(1, 6)[0];
                Assert.IsTrue(Digits.DigitValue.ToInt() > 0 && Digits.DigitValue.ToInt() < 7);
            }
        }
    }
}
