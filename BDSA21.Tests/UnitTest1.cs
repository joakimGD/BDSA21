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

            var actual1 = testProgram.IsLeapYear(1800);
            var actual2 = testProgram.IsLeapYear(1900);
            var actual3 = testProgram.IsLeapYear(1600);
            var actual4 = testProgram.IsLeapYear(2004);

            Assert.False(actual1);
            Assert.False(actual2);
            Assert.True(actual3);
            Assert.True(actual4);
        }

        
    }

    public class UnitTest2
    {
        [Fact]
        public void Check_if_calculateLeapYear_takes_user_input()
        {
            Program testProgram = new Program();

            var actual1 = testProgram.calculateLeapYear("1800");
            var actual2 = testProgram.calculateLeapYear("1900");
            var actual3 = testProgram.calculateLeapYear("1600");
            var actual4 = testProgram.calculateLeapYear("2004");

            Assert.Equal(actual1, "nay");
            Assert.Equal(actual2, "nay");
            Assert.Equal(actual3, "yay");
            Assert.Equal(actual4, "yay");
        }

        
    }


}
