using Mod03Task1;
using NUnit.Framework;

namespace Mod05Tests
{
    [TestFixture]
    public class ReverseAllWordsTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ReverseSentence_GivenNull_TrowsError()
        {
            //Arrange
            string input = null;
            //Act & Assert
            Assert.That(() => ReverseAllWords.ReverseSentence(input), Throws.Exception);
        }
        [Test]
        public void ReverseSentence_CheckingLength()
        {
            //Arrange
            string input = "";
            //Act & Assert
            Assert.That(() => ReverseAllWords.ReverseSentence(input), Throws.Exception);
        }
        [Test]
        public void ReverseSentence_IsWorkingNormally()
        {
            //Arrange
            string input = "Day is Over? Finally! Im free. Moral: work first; drink later";
            string expected = "later drink first work Moral free Im Finally Over is Day";
            //Act & Assert
            Assert.AreEqual(expected, ReverseAllWords.ReverseSentence(input));
        }
    }
}