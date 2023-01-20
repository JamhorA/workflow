using TestProject1.Components;
using Xunit;

namespace TestProject1.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionTest()
        {
            var calculator = new Calculator();
            int result = calculator.Add(5,2);
            int expected = 7;
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData(5, 2, 3)]
		[InlineData(1, 1, 0)]
		[InlineData(5, 1, 4)]
		[InlineData(5, -2, 7)]
		public void MultipleMinusTests(int number, int secondNumber, int expected) 
        { 
            var calculator = new Calculator();

            var result = calculator.Minus(number, secondNumber);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(5,5,10, "+")]
        [InlineData(5,2,3, "-")]
        [InlineData(10,5,2, "/")]
        [InlineData(3,5,15, "*")]
        public void GeneralCalc(int number, int secondNumber, int expected, string calcType)
        {
            var calculator = new Calculator();
            int result = calculator.Calc(number, secondNumber, calcType);
            Assert.Equal(expected, result);
        }
    }
}