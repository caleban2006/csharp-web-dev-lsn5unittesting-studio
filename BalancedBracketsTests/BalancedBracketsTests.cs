using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void BalancedBracketWithStringsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void MultipleBalacnedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[][]]"));
        }

        [TestMethod]
        public void StartingWithClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OneBalancedBracketWithExtraClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch[Co]de]"));
        }
        
        [TestMethod]
        public void NoBalancedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void NoClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void OnlyClosingBracketWithStringsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code"));
        }

        [TestMethod]
        public void MultipleBalacnedBracketsWithStringsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[H[E]L[L]O]"));
        }

        [TestMethod]
        public void WholeBunchOfBalancedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[]][[[[][]]]]]]]"));
        }

        [TestMethod]
        public void NumbersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("1234"));
        }

        [TestMethod]
        public void SpecialCharactersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("!@#$"));
        }

        [TestMethod]
        public void BBracketsWithNumbersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("1[23]4"));
        }

        [TestMethod]
        public void BbracketsWithSpecialCharacterssAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("!@[#$]"));
        }

    }
}