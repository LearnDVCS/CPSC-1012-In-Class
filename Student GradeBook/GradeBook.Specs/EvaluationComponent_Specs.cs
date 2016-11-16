using System;
using GradeBook; // to get my EvaluationComponent class
using Xunit; // for my unit testing framework

namespace GradeBook.Specs
{
    public class EvaluationComponent_Specs
    {
        [Fact] // An attribute that "decorates" my tesing method
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

    }
}
