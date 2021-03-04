using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTests
    {
        double result, Sresult, Mresult, Dresult;
        [SetUp]
        public void SetUpMethod()
        {
            Sresult = 0;
            result = 0;
            Mresult = 0;
            Dresult = 0;
        }
        //ADD
        [Test]
        public void CalculatorAddMethod()
        {
            Calculator add = new Calculator();
            result = add.Addition(40, 20);
            Assert.AreEqual(60, result);
        }
        [Test]
        [TestCase(20, 25, 45)]
        public void CalculatorAddMethod(int x, int y, int expected)
        {
            Calculator add = new Calculator();
            result = add.Addition(x, y);
            Assert.AreEqual(expected, result);
        }
        
        //SUBSTRACT
        [Test]
        [TestCase(70, 20, 50)]
        [TestCase(10, 5, 5)]
        public void CalculatorSubParameter(int x, int y, int expected)
        {
            Calculator sub = new Calculator();
            Sresult = sub.Subtraction(x, y);
            Assert.AreEqual(expected, Sresult);
        }

        //MULTIPLICATION
        [Test]
        [TestCase(9, 2, 18)]
        [TestCase(4, 5, 20)]
        public void CalculatorMulParameter(int x, int y, int expected)
        {
            Calculator mul = new Calculator();
            Mresult = mul.Multiplication(x, y);
            Assert.AreEqual(expected, Mresult);
        }

        //DIVISION
        [Test]
        public void CalculateDivision()
        {
            Calculator div = new Calculator();
            Dresult = div.Division(14, 7);
            Assert.AreEqual(2, Dresult);
        }
        [Test]
        [TestCase(6, 3, 2)]
        [TestCase(2, 0, 0)]
        public void CalculatorDivParameter(int x, int y, int expected)
        {
            Calculator div = new Calculator();

            try
            {
                    Dresult = div.Division(x, y);
                    Assert.AreEqual(expected, Dresult);
            }
            catch
            {
                
                Assert.Fail("Divion by zero");
            }
        }
        [TearDown]
        public void CleanUpMethod()
        {
            Sresult = 0;
            result = 0;
            Mresult = 0;
            Dresult = 0;
        }
    }
}
