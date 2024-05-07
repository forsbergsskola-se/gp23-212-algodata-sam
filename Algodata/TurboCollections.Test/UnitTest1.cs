using NUnit.Framework;
using TurboCollections;

namespace TurboCollections.Test
{
    public class TurboMathsTests
    {
        [Test]
        public void SayHelloExists()
        {
            // Invoke SayHello method
            TurboMaths.SayHello();

            // Explicitly pass the test
            Assert.Pass();
        }
    }
}