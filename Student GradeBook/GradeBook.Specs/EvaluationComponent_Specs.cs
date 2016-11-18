using System;
using GradeBook; // to get my EvaluationComponent class
using Xunit; // for my unit testing framework

namespace GradeBook.Specs
{
    public class EvaluationComponent_Specs
    {
        [Fact] // An attribute that "decorates" my testing method
        public void Should_Create_EvaluationComponent()
        {
            // Arrange - Set up any variables/objects/expectations
            string expectedName = "Quiz 1";
            int expectedWeight = 5; // 5%

            // Act     - Do the thing I need to do/test
            EvaluationComponent itemBeingTested = new EvaluationComponent(expectedName, expectedWeight);

            // Assert  - Check that it worked right
            Assert.Equal(expectedName, itemBeingTested.Name);
            Assert.Equal(expectedWeight, itemBeingTested.Weight);
        }

        [Theory]
        [InlineData(101)]
        [InlineData(0)]
        [InlineData(-5)]
        public void Should_Reject_Invalid_Weight(int weight)
        {
            // Arrange
            var name = "Quiz 1";
            // var weight = 101; // <--- the value that should be too big.
            // var is a keyword that tells the compiler to figure out the
            // datatype from the value assigned to the variable

            // Act
            // A delegate here is a reference to a function
            Func<EvaluationComponent> action = delegate () 
            {   // this is my anonymous in-line function.
                // It is anoymous, because it doesn't have it's own name.
                // It is in-line, because I'm actually nesting it inside
                // of another method.
                return new EvaluationComponent(name, weight);
            };

            // Assert
            Assert.Throws<Exception>(action); // .Throws() will contain the "explosion"
        }

        [Theory]
        [InlineData(16, 12)]
        [InlineData(18, 18)]
        [InlineData(30, 4)]
        public void Should_Calculate_Mark(int possible, double earned)
        {
            // Arrange
            double expectedPercent = (earned / possible) * 100; // calculate what I expect
            EvaluationComponent itemBeingTested = new EvaluationComponent("Quiz 1", 20);

            // Act
            itemBeingTested.PossibleMarks = possible;
            itemBeingTested.EarnedMark = earned;
            var actualMark = itemBeingTested.Mark;

            // Assert
            Assert.Equal(expectedPercent, actualMark);
        }
    }
}
