using Xunit;

namespace Aquarius.SayHello.Test
{
    public class Talk_Test
    {
        [Fact]
        public void Talk_Should_Be_Hello()
        {
            var result = Talk.Hello();

            Assert.Equal("Hello", result);
        }
    }
}
