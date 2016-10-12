using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssortedExamples; // get the Square class from the other project
using Xunit;

namespace AssortedExamples.Specs
{
    public class Square_Specifications
    {
        [Fact]
        public void Should_Store_Side_Length()
        {
            // Arrange
            Square objectBeingTested;
            int expectedSideLength = 5;
            // Act
            objectBeingTested = new Square(expectedSideLength);
            // Assert
            Assert.Equal(expectedSideLength, objectBeingTested.Side);
        }

        //[Fact] // An annotation for something always true
        [Theory]
        [InlineData(5, 25)]
        [InlineData(1, 1)]
        [InlineData(3, 9)]
        public void Should_Calculate_Area(int sideLength,
            int expectedArea)
        {
            // Arrange
            Square sut; // Situation Under Test
            
            // Act
            sut = new Square(sideLength);
            // Assert
            Assert.Equal(expectedArea, sut.Area);
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(2, 8)]
        [InlineData(3, 12)]
        public void Should_Calculate_Perimeter(int givenSideLength, int expectedPerimeter)
        {
            // Arrange
            Square sut;
            // Act
            sut = new Square(givenSideLength);
            // Assert
            Assert.Equal(expectedPerimeter, sut.Perimeter);
        }
    }
}
