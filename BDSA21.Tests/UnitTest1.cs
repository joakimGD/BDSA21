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

            Console.SetIn(new StringReader("1600"));

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            Program.Main(new string[0]);

            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", actual);
           
        }

        
    }

    /*public class UnitTest3
    {
        [Fact]

        public void Check_checkException_method_catches_errors()
        {
            Console.SetIn(new StringReader("1500"));

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            Program.Main(new string[0]);

            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Year must be an integer larger than 1582, try again.", actual);
        }
    }
    public class UnitTest4
    {
        [Fact]

        public void Check_checkException_method_catches_errors()
        {
            Console.SetIn(new StringReader("abc"));

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            Program.Main(new string[0]);

            var actual = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Year must be an integer larger than 1582, try again.", actual);
        }
    }*/


}
