using Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class FractionTests
    {
        [Fact]
        public void ShouldAddFractions()
        {
            // Arrange
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(3, 4);

            // Act
            first.Add(second);

            // Assert
            Assert.True(first.Denominator.Equals(8));
            Assert.True(first.Numerator.Equals(10));
        }
    }
}
