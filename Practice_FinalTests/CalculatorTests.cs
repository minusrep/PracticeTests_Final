using Practice_Final;

namespace Practice_FinalTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Initialize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            float result = _calculator.Add(2.0f, 3.0f);
            Assert.AreEqual(5.0f, result);
        }

        [TestMethod]
        public void Add_NegativeAndPositiveNumbers_ReturnsSum()
        {
            float result = _calculator.Add(-2.0f, 3.0f);
            Assert.AreEqual(1.0f, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            float result = _calculator.Add(2.0f, -3.0f);
            Assert.AreEqual(-1.0f, result);
        }

        [TestMethod]
        public void Add_Zeroes_ReturnsZero()
        {
            float result = _calculator.Add(0.0f, 0.0f);
            Assert.AreEqual(0.0f, result);
        }

        [TestMethod]
        public void Subtract_PositiveNumbers_ReturnsDifference()
        {
            float result = _calculator.Subtract(5.0f, 3.0f);
            Assert.AreEqual(2.0f, result);
        }

        [TestMethod]
        public void Subtract_SmallerFromLarger_ReturnsNegativeDifference()
        {
            float result = _calculator.Subtract(3.0f, 5.0f);
            Assert.AreEqual(-2.0f, result);
        }

        [TestMethod]
        public void Subtract_Zeroes_ReturnsZero()
        {
            float result = _calculator.Subtract(0.0f, 0.0f);
            Assert.AreEqual(0.0f, result);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsDifference()
        {
            float result = _calculator.Subtract(-5.0f, -3.0f);
            Assert.AreEqual(-2.0f, result);
        }

        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            float result = _calculator.Multiply(2.0f, 3.0f);
            Assert.AreEqual(6.0f, result);
        }

        [TestMethod]
        public void Multiply_NegativeAndPositiveNumbers_ReturnsNegativeProduct()
        {
            float result = _calculator.Multiply(-2.0f, 3.0f);
            Assert.AreEqual(-6.0f, result);
        }

        [TestMethod]
        public void Multiply_PositiveAndNegativeNumbers_ReturnsNegativeProduct()
        {
            float result = _calculator.Multiply(2.0f, -3.0f);
            Assert.AreEqual(-6.0f, result);
        }

        [TestMethod]
        public void Multiply_Zeroes_ReturnsZero()
        {
            float result = _calculator.Multiply(0.0f, 0.0f);
            Assert.AreEqual(0.0f, result);
        }

        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            float result = _calculator.Divide(6.0f, 3.0f);
            Assert.AreEqual(2.0f, result);
        }

        [TestMethod]
        public void Divide_NegativeAndPositiveNumbers_ReturnsNegativeQuotient()
        {
            float result = _calculator.Divide(-6.0f, 3.0f);
            Assert.AreEqual(-2.0f, result);
        }

        [TestMethod]
        public void Divide_PositiveAndNegativeNumbers_ReturnsNegativeQuotient()
        {
            float result = _calculator.Divide(6.0f, -3.0f);
            Assert.AreEqual(-2.0f, result);
        }

        [TestMethod]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            float result = _calculator.Divide(0.0f, 3.0f);
            Assert.AreEqual(0.0f, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            float result = _calculator.Divide(6.0f, 0.0f);
        }

        [TestMethod]
        public void Add_MaxValueAndPositiveNumber_ReturnsPositiveInfinity()
        {
            float result = _calculator.Add(float.MaxValue, 1.0f);
            Assert.AreEqual(float.MaxValue, result);
        }

        [TestMethod]
        public void Subtract_MinValueAndPositiveNumber_ReturnsNegativeInfinity()
        {
            float result = _calculator.Subtract(float.MinValue, 1.0f);
            Assert.AreEqual(float.MinValue, result);
        }

        [TestMethod]
        public void Multiply_MaxValueAndPositiveNumber_ReturnsPositiveInfinity()
        {
            float result = _calculator.Multiply(float.MaxValue, 2.0f);
            Assert.IsTrue(float.IsPositiveInfinity(result));
        }
    }
}