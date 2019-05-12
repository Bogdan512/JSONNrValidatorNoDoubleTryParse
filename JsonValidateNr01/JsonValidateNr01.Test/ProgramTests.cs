using System;
using Xunit;

namespace JsonValidateNr01.Test
{
    public class ProgramTests
    {

        [Fact]
        public void FirstGreenTestMinimumImplementation()
        {
            string input = "Test";
            bool expected = true;
            bool actual = Program.ValidateJsonNr(input);
            Assert.Equal(expected, actual);
        }
    }
}
