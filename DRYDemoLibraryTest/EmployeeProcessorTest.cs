using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DRYDemoLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Farrukh", "Inomov", "FarrInom")]
        [InlineData("Far", "Ino", "FarXInoX")]
        [InlineData("Ann", "King", "AnnXKing")]
        public void GenerateEmployeeID_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName).Substring(0, expectedStart.Length);
            
            // Assert
            Assert.Equal(expectedStart, actualStart);
        }

    }
}
