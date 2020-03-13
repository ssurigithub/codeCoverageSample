using System;
using Xunit;

namespace calculatorLibrary.Tests
{
    public class CalculatorTests
    {
        

        

        // [Fact]
        // public void Test1()
        // {
        //     Assert.Pass();
        // }

        [Theory]
        [InlineData(4,5, 9)]
        [InlineData(1,2, 3)]
        [InlineData(1,10, 11)]
        public void TestAddition(int x, int y, int result)
        {
            var calc = new calculatorLibrary.Calculator();
            Assert.Equal(result, calc.Add(x,y));
        }


        [Theory]
        [InlineData(5,4, 1)]
        [InlineData(5,2, 3)]
        
        public int TestSubtraction(int x, int y, int result)
        {
            var calc = new calculatorLibrary.Calculator();
            return calc.Subtract(x,y);
            
        }

         [Theory]
        [InlineData(5,4, 20)]
        [InlineData(5,2, 10)]
        
        public int TestMultiply(int x, int y, int result)
        {
            var calc = new calculatorLibrary.CalculatorComplex();
            return calc.Multiply(x,y);
            
        }

         [Theory]
        [InlineData(8,4, 2)]
        [InlineData(5,5, 1)]
        
        public int TestDivision(int x, int y, int result)
        {
            var calc = new calculatorLibrary.CalculatorComplex();
            return calc.Divide(x,y);
            
        }
    }
}
