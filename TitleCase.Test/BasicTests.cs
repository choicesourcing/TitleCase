using System;
using Xunit;

namespace TitleCase.Test
{
    public class BasicTests
    {
        [Theory]
        [InlineData("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [InlineData("THE WIND IN THE WILLOWS","The In","The Wind in the Willows")]
        public void BasicNameWithList(string title, string minorWords, string expected)
        {

            var actual = StringUtilities.TitleCase(title, minorWords);
            Assert.Matches(expected, actual);
        }
        
        [Theory]
        [InlineData("", "", "")]
        public void EmptyData(string title, string minorWords, string expected)
        {

            var actual = StringUtilities.TitleCase(title, minorWords);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("the quick brown fox", "", "The Quick Brown Fox")]
        public void NoMinorWords(string title, string minorWords, string expected)
        {

            var actual = StringUtilities.TitleCase(title, minorWords);
            Assert.Equal(expected, actual);
        }
    }
}