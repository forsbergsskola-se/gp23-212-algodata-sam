using NUnit.Framework;
using System.Collections.Generic;
using P1_3_Iterator.TurboCollections;

namespace TurboCollections.Test
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void Test_GetEvenNumbersList()
        {
            Assert.That(TurboMaths2.GetEvenNumbersList(12), Is.EqualTo(new List<int> { 0, 2, 4, 6, 8, 10, 12 }));
            Assert.That(TurboMaths2.GetEvenNumbersList(15), Is.EqualTo(new List<int> { 0, 2, 4, 6, 8, 10, 12, 14 }));
            Assert.That(TurboMaths2.GetEvenNumbersList(-1), Is.EqualTo(new List<int>()));
            Assert.That(TurboMaths2.GetEvenNumbersList(0), Is.EqualTo(new List<int> { 0 }));
        }

        [Test]
        public void Test_GetEvenNumbers()
        {
            Assert.That(new List<int>(TurboMaths2.GetEvenNumbers(12)), Is.EqualTo(new List<int> { 0, 2, 4, 6, 8, 10, 12 }));
            Assert.That(new List<int>(TurboMaths2.GetEvenNumbers(15)), Is.EqualTo(new List<int> { 0, 2, 4, 6, 8, 10, 12, 14 }));
            Assert.That(new List<int>(TurboMaths2.GetEvenNumbers(-1)), Is.EqualTo(new List<int>()));
            Assert.That(new List<int>(TurboMaths2.GetEvenNumbers(0)), Is.EqualTo(new List<int> { 0 }));
        }
    }
}