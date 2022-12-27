using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("house", false)]
        [InlineData("cinegenic", true)]
        [InlineData("deed", true)]
        [InlineData("coding", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();

            //Act
            var actual = instance.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
