using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(1584)] //First rule
        [InlineData(1600)] //Third rule
        public void IsLeapYear_writes_yay_on_correct_years(int year)
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.IsLeapYear(year);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay",output);
            
        }

        [Theory]
        [InlineData(1700)] //Second rule
        [InlineData(1580)] //Exercise 7 rule
        public void IsLeapYear_writes_nay_on_incorrect_years(int year)
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.IsLeapYear(year);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay",output);
            
        }

        [Fact]
        public void Main_prints_error_message_on_text_input()
        {
            //Arrange
            var writer = new StringWriter();
            var reader = new StringReader("bad");
            Console.SetOut(writer);
            Console.SetIn(reader);
            
            //Act
            Program.Main(new string[0]);
            
            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Input should be a number!",output);

        }
    }
}
