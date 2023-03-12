using Module16;
using Xunit;

namespace Task1.Tests
{
    public class CalculatorTests
    {
        //Каждую отделюную функцию обкладываем тестами

        [Fact]
        public void AdditionalMustReturnExpectedResult()
        {
            var calculator = new Calculator();

            Assert.Equal(calculator.Additional(5, 0), 5);
            Assert.Equal(calculator.Additional(5, 5), 10);
            Assert.Equal(calculator.Additional(-10, -5), -15);
            Assert.Equal(calculator.Additional(10, -5), 5);
        }

        [Fact]
        public void SubtractionMustReturnExpectedResult()
        {
            var calculator = new Calculator();

            Assert.Equal(calculator.Subtraction(9, 7), 2);
            Assert.Equal(calculator.Subtraction(5, 7), -2);
            Assert.Equal(calculator.Subtraction(9, 0), 9);
            Assert.Equal(calculator.Subtraction(-6, -9), 3);
        }

        [Fact]
        public void MultiplicationMustReturnExpectedResult()
        {
            var calculator = new Calculator();

            Assert.Equal(calculator.Miltiplication(7, 7), 49);
            Assert.Equal(calculator.Miltiplication(7, 0), 0);
            Assert.Equal(calculator.Miltiplication(7, -7), -49);
            Assert.Equal(calculator.Miltiplication(-7, -7), 49);
        }

        [Fact]
        public void DivisionMustReturnExpectedResult()
        {
            var calculator = new Calculator();
            
            Assert.Equal(calculator.Division(9, 3), 3);
            Assert.Equal(calculator.Division(3, 9), 0);
            Assert.Equal(calculator.Division(0, 7), 0);
            Assert.Equal(calculator.Division(9, -3), -3);
            Assert.Equal(calculator.Division(-9, -3), 3);

            Assert.Throws<DivideByZeroException>(() => calculator.Division(7, 0));
        }
    }
}