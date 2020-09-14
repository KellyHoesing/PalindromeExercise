using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("phone", false)]
        [InlineData("Racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
