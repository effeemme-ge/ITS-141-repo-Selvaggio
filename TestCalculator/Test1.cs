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
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calculator = new Calculator();
            var result = calculator.Add(3, 0);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var calculator = new Calculator();
            var result = calculator.Add(3, -1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(3, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(15, 5);
            Assert.AreEqual(3, result);
        }
    }
}
