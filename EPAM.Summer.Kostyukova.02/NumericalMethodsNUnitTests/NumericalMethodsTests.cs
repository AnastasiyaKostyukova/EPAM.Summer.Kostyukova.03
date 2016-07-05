using NUnit.Framework;
using System;

namespace NumericalMethodsNUnitTests
{
    public class NumericalMethodsTests
    {
        [Test]
        [TestCase(10, 15, 5)]
        [TestCase(12, 15, 3)]
        [TestCase(16, 0, 16)]
        [TestCase(0, int.MinValue + 1, int.MaxValue)]
        public void TestTest(int a, int b, int expected)
        {
            // Arrange
            var expectedNod = expected;

            // Act
            var actualNod = NumericalMethods.NumericalMethods.EuclideanAlgorithmGCD(a, b);

            // Assert
            Assert.AreEqual(expectedNod, actualNod);
        }

        [Test]
        public void TestTestExp()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => NumericalMethods.NumericalMethods.EuclideanAlgorithmGCD(0, 0));
        }
    }
}
