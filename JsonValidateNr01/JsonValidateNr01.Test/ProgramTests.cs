using System;
using Xunit;

namespace JsonValidateNr01.Test
{
    public class ProgramTests
    {
        [Fact]
        public void RedTestForNotImplementedMethod()
        {
            Program.ValidateJsonNr("Test");
        }
    }
}
