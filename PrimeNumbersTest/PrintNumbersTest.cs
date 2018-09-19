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
    }
}
