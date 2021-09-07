using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_hello_world()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!",output);

        }

        [Theory]
        [InlineData(4)] //First rule
        [InlineData(400)] //Third rule
        public void IsLeapYear_returns_true_on_correct_years(int year)
        {
            //Arrange

            //Act
            var output = Program.IsLeapYear(year);

            //Assert
            Assert.True(output);
            
        }


        [Theory]
        [InlineData(1)] //First rule
        [InlineData(100)] //Second rule
        public void IsLeapYear_returns_false_on_incorrect_years(int year)
        {
            //Arrange

            //Act
            var output = Program.IsLeapYear(year);

            //Assert
            Assert.False(output);
            
        }
    }
}
