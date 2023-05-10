using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
		[InlineData(5, 5, 5, 15)]
		[InlineData(-10, 20, 8, 18)]
		[InlineData(100, 100, -199, 1)]
        
        //Add test data <-------
		public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calc = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(8, 8, 0)]
        [InlineData(10, 5, 5)]
                                //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var sub = new Calculator();
            //Act
            var actual = sub.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,5,5)]
		[InlineData(2,4,8)]
		[InlineData(12,12,144)]
		[InlineData(-2,4,-8)]
		[InlineData(-1,-1,1)]
		//Add test data <-------
		public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multi = new Calculator();
            //Act
            var actual = multi.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
		[InlineData(8,2,4)]
		[InlineData(15,3,5)]
		[InlineData(-75,5,-15)]
        //Add test data <-------
		public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var div = new Calculator();
            //Act
            var actual = div.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
