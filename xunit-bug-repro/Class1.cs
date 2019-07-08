using Xunit;

namespace xunit_bug_repro
{
    public class Class1
    {
        [Fact]
        public void this_test_has_a_pretty_nameX21()
        {
            Assert.True(false);
        }
    }
}
