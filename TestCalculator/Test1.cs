using LibCalculator;

namespace TestCalculator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();
            var result = calculator.Add(3, 5);
            Assert.Equals(7, result);
        }
    }
}
