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
    }
}
