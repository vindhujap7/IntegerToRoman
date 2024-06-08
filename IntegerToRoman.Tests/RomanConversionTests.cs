using NUnit.Framework;
using System;

namespace IntegerToRoman.Tests
{
    public class RomanConversionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(2022, "MMXXII")]
        [TestCase(3999, "MMMCMXCIX")]
        public void ConvertIntToRoman_Test(int number, string expected)
        {
            string romanResult = IntegerConversion.ConvertIntToRoman(number);

            Assert.AreEqual(expected, romanResult);
        }

        [TestCase(0)]
        [TestCase(4000)]
        public void ConvertIntToRoman_OutOfRange_Test(int number)
        {

            var message = Assert.Throws<Exception>(() => IntegerConversion.ConvertIntToRoman(number));


            Assert.AreEqual("Number needs to be between 1 and 3999", message.Message);
        }

    }

}