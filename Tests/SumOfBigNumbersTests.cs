using Mod03Task1;
using NUnit.Framework;

namespace Mod05Tests
{
    [TestFixture]
    public class SumOfBigNumbersTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TooBig_GivenNull_TrowsError()
        {
            //Arrange
            string num1 = "1";
            string num2 = null;
            //Act & Assert
            Assert.That(() => SumOfBigNumbers.TooBig(num1, num2), Throws.ArgumentNullException);
        }
        [Test]
        public void TooBig_GivenEmpty_TrowsError()
        {
            //Arrange
            string num1 = "1";
            string num2 = "";
            //Act & Assert
            Assert.That(() => SumOfBigNumbers.TooBig(num1, num2), Throws.ArgumentException);
        }
        [Test]
        public void TooBig_IsWorkingNormally()
        {
            //Arrange
                string num1 = "500";
                string num2 = "500";
            string expected = "1000";

            //Act
            string sum = SumOfBigNumbers.TooBig(num1, num2);
            //Assert
            Assert.AreEqual(expected, sum);
        }
    }
}