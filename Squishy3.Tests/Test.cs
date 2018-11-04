namespace Squishy3.Tests
{
    using System;
    using Xunit;
    using Shouldly;

    public class Test
    {
        [Fact]
        public void ValueIsAValue()
        {
            var value = 1;
            value.ShouldBe(1);
        }
    }
}
