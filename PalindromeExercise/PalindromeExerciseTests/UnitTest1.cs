using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("foot", false)]
        [InlineData("tooth", false)]
        [InlineData("mad", false)]
        [InlineData("aaaaa", true)]
        public void IsAPalindrome(string a, bool expected)
        {
            var word = new WordSmith();

            var actual = word.IsAPalindrome(a);

            Assert.Equal(expected, actual);
        }
    }
}
