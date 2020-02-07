using System;
using FizzBuzz;
using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    public class FizzBuzzGeneratorUnitTests: With_an_automocked<FizzBuzzGenerator>
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(50, "Buzz")]
        [TestCase(55, "Buzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(100, "Buzz")]
        public void Should_load_fizz_buzz(int number, string expectedResult)
        {
            var fizzBuzz = ClassUnderTest.LoadFizzBuzz();

            var index = number - 1;
            
            Assert.That(fizzBuzz[index], Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Should_return_1_to_100()
        {
            var fizzBuzz = ClassUnderTest.ShouldReturn1To100();
            
            // fizzBuzz[^1] - the `hat` operator, gets the last element of an array
            var first = 0;
            var last = ^1;
            
            Assert.That(fizzBuzz.Length, Is.EqualTo(100));
            Assert.That(fizzBuzz[first], Is.EqualTo(1));
            Assert.That(fizzBuzz[last], Is.EqualTo(100));
        }

        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        public void Is_divisible_by_3(int input, bool expectedResult)
        {
            var result = ClassUnderTest.IsDivisibleBy3(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, false)]
        [TestCase(10, true)]
        public void Should_return_Buzz_if_visible_by_5(int input, bool expectedResult)
        {
            var result = ClassUnderTest.IsDivisibleBy5(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        
        
    }
}