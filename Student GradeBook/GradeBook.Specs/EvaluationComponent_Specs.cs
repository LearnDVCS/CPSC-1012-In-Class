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

            // Assert  - Check that it worked correctly
            Assert.Equal(expectedName, itemBeingTested.Name);
            Assert.Equal(expectedWeight, itemBeingTested.Weight);
        }

        [Theory]
        [InlineData(0)] // This is a value that will be passed into the method
        [InlineData(-5)]
        [InlineData(101)]
        public void Should_Reject_Invalid_Weight(int weight)
        {
            // Arrange
            string name = "Quiz 1";

            // Act
            // A Func<T> is a kind of delegate where the delegate method
            // returns a T object.
            // The delegate keyword defines something as being a method.
            // We are effectively creating an "inline method" or "anonymous method"
            // that returns a new EvaluationComponent.
            Func<EvaluationComponent> createObjectMethod = 
                delegate { return new EvaluationComponent(name, weight); } ;

            // Assert
            Assert.Throws<Exception>(createObjectMethod);
        }
    }
}
