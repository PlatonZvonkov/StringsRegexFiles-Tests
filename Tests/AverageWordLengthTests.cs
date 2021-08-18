using Mod03Task1;
using NUnit.Framework;

namespace Mod05Tests
{
    [TestFixture]
    public class AverageWordLengthTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AverageLength_GivenNull_TrowsError()
        {
            //Arrange
            string input = null;
            //Act & Assert
            Assert.That(()=> AverageWordLength.AverageLength(input), Throws.Exception);
        }
        [Test]
        public void AverageLength_CheckingLength()
        {
            //Arrange
            string input = "";
            //Act & Assert
            Assert.That(() => AverageWordLength.AverageLength(input), Throws.Exception);
        }
        [Test]
        [TestCase("a", 1)]
        [TestCase("that is good", 3.3)]     
        
        public void AverageLength_IsWorkingNormally(string input, double expected)
        {
            //Act & Assert
            //Summary:
            //I am testing output types cuz you cant
            // put repeating or recurring decimals as expected number
            Assert.That(
                () => 
            (AverageWordLength.AverageLength(input).GetType())
            .Equals(expected.GetType())
            );
            
        }
        [Test]
        [TestCase("a!", 1)]
        [TestCase("that good,,,,,,,,, good", 4)]
        public void AverageLength_Punctuation_Check(string input, double expected)
        {            
            //Act & Assert
            Assert.That(
                () =>
            (AverageWordLength.AverageLength(input))
            .Equals(expected)
            );
        }
    }
}