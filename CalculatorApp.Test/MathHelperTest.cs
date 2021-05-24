using System;
using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        private readonly MathHelper _calculator;// = new MathHelper();
        public MathHelperTest()
        {
            _calculator = new MathHelper();
        }

        [Fact]
        public void IsEven()
        {
            var calculator = new MathHelper(); //Arrange
            int x = 12;
            int y = 43;

            //Act
            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);


            //Assert
            Assert.True(xResult);
            Assert.False(yResult);

        }

        [Theory]
        [InlineData(3)]
        public void IsOddTest(int x)
        {
           
            var result = _calculator.IsOdd(x);

            Assert.True(result);
        }

        [Fact]
        public void DifferenceTest()
        {
            int x = 4;
            int y = 12;
            var result = _calculator.Diff(x, y);
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(2,4,6)]
        public void AddTest(int x, int y, int expectedResult)
        {
            var result = _calculator.Add(x, y);

            Assert.Equal(result, expectedResult);
        }
        
        [Theory]
        [InlineData(new int[4] { 2, 4, 5, 4 }, 15)]
        [InlineData(new int[4] { 2, 2, 2, 4 }, 10)]
        [InlineData(new int[3] { -4, -6, -10 }, -20)]
        public void SumTest(int[]x, int expectedX)
        {
            var result = _calculator.Sum(x);

            Assert.Equal(expectedX, result);
        }

        [Theory]
        [InlineData(new int[4] { 2, 4, 6, 4 }, 4)]
        [InlineData(new int[3] { 2, 2, 5 }, 3)]
        [InlineData(new int[2] { -4, -6 }, -5)]
        public void AverageTest(int[] x, int expectedX)
        {
            var result = _calculator.Average(x);

            Assert.Equal(expectedX, result);
        }

        [Theory]
        [MemberData(nameof(MathHelper.Data), MemberType = typeof(MathHelper))]
        public void Add_MemberData_Test(int x, int y, int expectedValue)
        {
            var result = _calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }
    }
}
