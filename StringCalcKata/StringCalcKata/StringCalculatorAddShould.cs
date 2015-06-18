using NUnit.Framework;

namespace StringCalcKata
{
    [TestFixture]
    public class StringCalculatorAddShould
    {
        [Test]
        public void ReturnZeroGivenEmptyString()
        {
            var calc = new StringCalculator();
            var result = calc.Add("");

            Assert.AreEqual(0, result);
        }
        [Test]
        public void Return1Given1AsString()
        {
            var calc = new StringCalculator();
            var result = calc.Add("1");

            Assert.AreEqual(1, result);
 
        }
    }
}