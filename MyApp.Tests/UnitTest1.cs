using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class MainTests
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
    }
}
