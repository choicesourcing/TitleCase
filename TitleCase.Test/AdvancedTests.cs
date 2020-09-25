using System.Runtime.InteropServices;
using Xunit;

namespace TitleCase.Test
{
    public class AdvancedTests
    {
        [Theory]
        [InlineData("aBC deF Ghi", null, "Abc Def Ghi")]
        [InlineData("ab","ab","Ab")]
        [InlineData("a bc","bc","A bc")]
        [InlineData("a bc","BC","A bc")]
        [InlineData("First a of in","an often into","First A Of In")]
        [InlineData("a clash of KINGS","a an the OF","A Clash of Kings")]
        [InlineData("the QUICK bRoWn fOX","xyz fox quick the","The quick Brown fox")]
        public void BasicNameWithList(string title, string minorWords, string expected)
        {

            var actual = StringUtilities.TitleCase(title, minorWords);
            Assert.Matches(expected, actual);
        }
    }
}