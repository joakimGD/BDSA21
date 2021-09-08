using System;
using System.IO;
using Xunit;

namespace BDSA21.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Check_if_IsLeapYear_is_Correct()
        {
            Program testProgram = new Program();

            var actual1 = testProgram.calculateLeapYear(1800);
            var actual2 = testProgram.calculateLeapYear(1900);
            var actual3 = testProgram.calculateLeapYear(1600);
            var actual4 = testProgram.calculateLeapYear(2004);

            Assert.False(actual1);
            Assert.False(actual2);
            Assert.True(actual3);
            Assert.True(actual4);
        }
    }
}
