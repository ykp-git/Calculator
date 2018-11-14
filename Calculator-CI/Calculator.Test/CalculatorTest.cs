using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Divide()
        {
            //Arrange to initial and set data
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act

            int actual = Calculator.Library.Calculator.Divide(numerator, denominator);

            //Assert 
            Assert.AreEqual(expected, actual);

            
        }
    }
}
