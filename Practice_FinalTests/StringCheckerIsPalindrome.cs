using Practice_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FinalTests
{
    [TestClass]
    public class StringCheckerIsPalindromeTests
    {
        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            var value = "";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            var value = "A";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindrome_EvenPalindrome_ReturnsTrue()
        {
            var value = "AGGA";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindrome_OddPalindrome_ReturnsTrue()
        {
            var value = "AGA";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindrome_EvenNonPalindrome_ReturnsFalse()
        {
            var value = "AGGG";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPalindrome_OddNonPalindrome_ReturnsFalse()
        {
            var value = "AGG";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPalindrome_PalindromeWithMixedCase_ReturnsTrue()
        {
            var value = "AgA";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindrome_PalindromeWithSpaces_ReturnsTrue()
        {
            var value = "A G A";
            var result = StringChecker.IsPalindrome(value);
            Assert.IsTrue(result);
        }
    }
}
