using Mod03Task1;
using NUnit.Framework;

namespace Mod05Tests
{
    [TestFixture]
    public class DobleStringCharactersTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DoubleStringCharactersTests_GivenNull_TrowsError()
        {
            //Arrange
            string input = "asd";
            string dobleThisChars = null;
            //Act & Assert
            Assert.That(() => DoubleStringCharacters.Doble(input, dobleThisChars), Throws.ArgumentNullException);

        }
        [Test]
        public void DobleStringCharactersTests_CheckingLength()
        {
            //Arrange
            string input = "asd";
            string dobleThisChars = "";
            //Act & Assert
            Assert.That(() => DoubleStringCharacters.Doble(input, dobleThisChars), Throws.ArgumentException);
        }
        [Test]
        [TestCase("this is good","i", "thiis iis good")]
        [TestCase("this is bad", "thisisverybadindeed", "tthhiiss iiss bbaadd")]
        public void DobleStringCharactersTests_IsWorkingNormally(string input,string doble,string expected)
        {
            //Act & Assert
            Assert.That(() => DoubleStringCharacters.Doble(input, doble).Equals(expected));
        }
        
    }
}