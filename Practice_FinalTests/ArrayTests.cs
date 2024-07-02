using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FinalTests
{
    [TestClass]
    public class ArrayTests
    {
        private Practice_Final.Array _array;

        [TestInitialize]
        public void Initialize()
        {
            _array = new Practice_Final.Array();
        }

        [TestMethod]
        public void Sum_PositiveNumbers_ReturnsSum()
        {
            float[] numbers = { 1, 2, 3, 4 };
            float result = _array.Sum(numbers);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Sum_NegativeNumbers_ReturnsSum()
        {
            float[] numbers = { -1, -2, -3, -4 };
            float result = _array.Sum(numbers);
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Sum_MixedNumbers_ReturnsSum()
        {
            float[] numbers = { 1, -2, 3, -4 };
            float result = _array.Sum(numbers);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Sum_EmptyArray_ReturnsZero()
        {
            float[] numbers = { };
            float result = _array.Sum(numbers);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            float[] numbers = { 1, 2, 3, 4 };
            float result = _array.Multiply(numbers);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            float[] numbers = { -1, -2, -3, -4 };
            float result = _array.Multiply(numbers);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Multiply_MixedNumbers_ReturnsProduct()
        {
            float[] numbers = { 1, -2, 3, -4 };
            float result = _array.Multiply(numbers);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Multiply_EmptyArray_ReturnsOne()
        {
            float[] numbers = { };
            float result = _array.Multiply(numbers);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Average_PositiveNumbers_ReturnsAverage()
        {
            float[] numbers = { 1, 2, 3, 4 };
            float result = _array.Average(numbers);
            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        public void Average_NegativeNumbers_ReturnsAverage()
        {
            float[] numbers = { -1, -2, -3, -4 };
            float result = _array.Average(numbers);
            Assert.AreEqual(-2.5, result);
        }

        [TestMethod]
        public void Average_MixedNumbers_ReturnsAverage()
        {
            float[] numbers = { 1, -2, 3, -4 };
            float result = _array.Average(numbers);
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Average_EmptyArray_ReturnsArgumentExeption()
        {
            float[] numbers = { };
            Assert.ThrowsException<ArgumentException>(() => _array.Average(numbers));
        }
    }
}
