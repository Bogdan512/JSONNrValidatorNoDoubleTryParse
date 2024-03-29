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

        [Fact]
        public void For_A_Number_That_Starts_With_0_It_Should_Return_False()
        {
            string input = "0123";
            bool expected = false;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void For_Number_With_Incomplete_Exponential_Notation_It_Should_Return_False()
        {
            string input = "12.123E";
            bool expected = false;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void For_Number_With_A_Comma_At_The_End_It_Should_Return_False()
        {
            string input = "12.";
            bool expected = false;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
    }
}
