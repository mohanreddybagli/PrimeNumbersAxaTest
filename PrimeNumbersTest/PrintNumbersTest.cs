using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintNumberTypes;

namespace NumbersTest
{
    [TestClass]
    public class PrintNumbersTest
    {
        [TestMethod] 
        public void Return_Values_Including_StartingNumber()
        {
            int sNumber = 10;
            int eNumber = 20;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.Print(sNumber, eNumber);
            Assert.AreEqual(sNumber, int.Parse(result[0]));
        }
        [TestMethod]
        public void Return_Values_Including_endingNumber()
        {
            int sNumber = 10;
            int eNumber = 20;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.Print(sNumber, eNumber);
            Assert.AreEqual(eNumber, int.Parse(result[result.Count - 1]));
        }

        [TestMethod]
        public void Return_PrimeNumber()
        {
            int sNumber = 8;
            int eNumber = 12;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.PrintPrimeNumbers(sNumber, eNumber);
            Assert.AreEqual("Prime", result[3]);
        }
        [TestMethod]
        public void Return_non_PrimeNumber()
        {
            int sNumber = 14;
            int eNumber = 16;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.PrintPrimeNumbers(sNumber, eNumber);
            Assert.IsTrue(!result.Contains("Prime"));
        }
        [TestMethod]
        public void Return_Odd_CompositNumber()
        {
            int sNumber = 0;
            int eNumber = 10;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.PrintCompositNumbers(sNumber, eNumber);
            Assert.AreEqual("Composit", result[8]);
        }
        [TestMethod]
        public void Return_non_odd_CompositNumber()
        {
            int sNumber = 0;
            int eNumber = 8;

            PrintNumbers obj = new PrintNumbers();
            var result = obj.PrintCompositNumbers(sNumber, eNumber);
            Assert.IsTrue(!result.Contains("Composit"));
        }
    }
}
