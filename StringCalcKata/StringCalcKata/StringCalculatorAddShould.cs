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
    }
}