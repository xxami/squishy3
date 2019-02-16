namespace Squishy3.Tests.Config {

    using Shouldly;
    using Xunit;
    using global::Squishy3.Config;
    
    public class ValueTests {
        [Fact]
        public void ShouldBeValue() {
            1.ShouldBe(1);
        }
    }
}
