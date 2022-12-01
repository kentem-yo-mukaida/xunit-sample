using TestProject2.Models;

namespace TestProject2
{
    public class FunctionsTest
    {
        private readonly Functions _functions;

        public FunctionsTest()
        {
            _functions = new Functions();
        }

        [Fact]
        public void Sum()
        {
            Assert.Equal(1, _functions.Sum(1));
            Assert.Equal(3, _functions.Sum(1, 2));
            Assert.Equal(6, _functions.Sum(1, 2, 3));

            Assert.Equal(6, _functions.Sum(1, 2, 3, 4));
        }
    }
}