using System;
using Xunit;

namespace JsonValidateNr01.Test
{
    public class ProgramTests
    {
        [Fact]
        public void For_234_It_Should_Return_True()
        {
            string input = "234";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void For_Minus_123_It_Should_Return_True()
        {
            string input = "-123";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void For_Number_With_Comma_It_Should_Return_True()
        {
            string input = "12.34";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void For_Number_With_Comma_And_Multiplycation_By_10_3_times_It_Should_Return_True()
        {
            string input = "12.123e3";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void For_Number_With_Scientific_Notation_With_Plus_It_Should_Return_True()
        {
            string input = "12.123E+3";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void For_Number_With_Scientific_Notation_With_Minus_It_Should_Return_True()
        {
            string input = "12.123E-2";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
    }
}
