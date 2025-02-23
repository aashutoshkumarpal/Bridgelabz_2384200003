using System;
using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTest
{
    [TestFixture] // Indicates that this class contains NUnit tests
    public class Class1
    {
        private Calculator _calculator;

        [SetUp] // This method runs before each test
        public void Setup()
        {
            _calculator = new Calculator(); // Initialize the Calculator instance
        }

        [Test] // Marks this method as a test
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Test that adding 2 and 3 returns 5
            Assert.That(_calculator.Add(2, 3), Is.EqualTo(5));
        }

        [Test] // Marks this method as a test
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Test that subtracting 3 from 5 returns 2
            Assert.That(_calculator.Subtract(5, 3), Is.EqualTo(2));
        }

        [Test] // Marks this method as a test
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Test that multiplying 5 and 3 returns 15
            Assert.That(_calculator.Multiply(5, 3), Is.EqualTo(15));
        }

        [Test] // Marks this method as a test
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            // Test that dividing 6 by 3 returns 2
            Assert.That(_calculator.Divide(6, 3), Is.EqualTo(2));
        }

        [Test] // Marks this method as a test
        public void Divide_ByZero_ThrowsException()
        {
            // Test that dividing by zero throws a DivideByZeroException
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }
}