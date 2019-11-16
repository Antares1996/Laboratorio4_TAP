using System;
using NUnit.Framework;
using prova_iter;

namespace Test_Iteratori
{
    [TestFixture]
    public class test_iterator
    {
        [Test]
        public void iterator_NullArg_ThrowsArgumentException()
        {
            
            Assert.That(() => iter.MacroExpansion(null, 1, new[] { 1, 2, 3 }), Throws.TypeOf<ArgumentNullException>());
        }
    }
}
