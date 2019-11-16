using NUnit.Framework;
using prova_iter;
using System;

namespace prova
{
    public class IterTests
    {
        [Test]
        public void iter_MacroException_SequenzeThrowsArgumentNullException()
        {
            Assert.That(() => iter.MacroExpansion(null, 1, new[] { 1, 2, 3 }), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void iter_MacroException_NewvaluesThrowsArgumentNullException()
        {
            Assert.That(() => iter.MacroExpansion(new[] { 1, 2, 3 }, 1, null), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void iter_MacroException_ValueNotFoudInSequenze()
        {
            var seq = new[] { 1, 2, 3 };
            Assert.That(() => iter.MacroExpansion(seq, 4, new[] {0, 5}), Is.EqualTo(seq));
        }

       [Ignore("test incompleto")] [Test]
        public void iter_MacroException_ValueCompareOnlyOneInSequenze()
        {
            var seq = new[] { 1, 2, 3 };
            Assert.That(() => iter.MacroExpansion(seq, 2, new[] { 0, 5 }), Is.EqualTo(seq));
        }

    }
}