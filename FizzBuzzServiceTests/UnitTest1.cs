using FizzBuzzApi.Services;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FizzBuzzServiceTests
{
    public class Tests
    {
        FizzBuzzApi.Services.FizzBuzzService fizzBuzzService = new FizzBuzzApi.Services.FizzBuzzService();

        [SetUp]
        public void Setup()
        {
            FizzBuzzApi.Services.FizzBuzzService fizzBuzzService = new FizzBuzzApi.Services.FizzBuzzService();
            //fizzBuzzService = FizzBuzzApi.Services.FizzBuzzService;
        }

        [Test]
        public void TestFuzz()
        {
            // Arrange

            string[] StrValueFuzz = {"3"};  // Multiple of 3

            var result = fizzBuzzService.ProcessValues(StrValueFuzz);
         
            Assert.AreEqual("Fizz", result.Results[0]); // Check the result part
                
           
            Assert.Pass();
        }
        [Test]
        public void TestBuzz()
        {
            // Arrange

            string[] StrValueFuzz = { "5" };  // Multiple of 3

            var result = fizzBuzzService.ProcessValues(StrValueFuzz);

            Assert.AreEqual("Buzz", result.Results[0]); // Check the result part


            Assert.Pass();
        }
        [Test]
        public void TestFuzzBuzz()
        {
            // Arrange

            string[] StrValueFuzz = { "3","5" };  // Multiple of 3

            var result = fizzBuzzService.ProcessValues(StrValueFuzz);

            Assert.AreEqual("Buzz", result.Results[1]); // Check the result part


            Assert.Pass();
        }

        [Test]
        public void TestFuzzBuzzInvalid()
        {
            // Arrange

            string[] StrValueFuzz = { "" };  // Multiple of 3

            var result = fizzBuzzService.ProcessValues(StrValueFuzz);

            Assert.AreEqual("Invalid Item", result.Results[0]); // Check the result part


            Assert.Pass();
        }

        [Test]
        public void TestString()
        {
            // Arrange

            string[] StrValueFuzz = { "abc" };  // Multiple of 3

            var result = fizzBuzzService.ProcessValues(StrValueFuzz);

            Assert.AreEqual("Invalid Item", result.Results[0]); // Check the result part


            Assert.Pass();
        }
    }
}