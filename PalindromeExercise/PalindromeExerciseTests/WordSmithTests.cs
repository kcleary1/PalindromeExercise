using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PalindromeExercise;
    
namespace PalindromeExerciseTests
{
    public class WordSmithTests
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("Racecar", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);


        }
    }
}
