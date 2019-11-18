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

        [TestCase(1, new[] { 5, 6, 7, 2, 3 })]
        [TestCase(2, new[] { 1, 5, 6, 7, 3 })]
        [TestCase(3, new[] { 1, 2, 5, 6, 7})]
        public void iter_MacroException_ValueCompareOnceInSeq(int val, int[] expected)
        {
            var seq = new[] { 1, 2, 3 };
            var newval = new[] { 5, 6, 7 };
            Assert.That(() => iter.MacroExpansion(seq, val, newval), Is.EqualTo(expected));
        }

        [Test]
        public void iter_MacroException_ValueCompareMoreThatOnceInSeq()
        {
            var seq = new[] { 1, 4, 1, 3, 2, 3 };
            var val = 1;
            var newval = new[] {5};
            var expected = new[] { 5, 4, 5, 3, 2, 3 };
            Assert.That(() => iter.MacroExpansion(seq, val, newval), Is.EqualTo(expected));
        }

        [Test]
        public void iter_MacroException_NewvalIsEmpty()
        {
            var seq = new[] { 1, 4, 1, 3, 2, 3 };
            var val = 1;
            var newval = new int[0];
            var expected = new[] {4, 3, 2, 3 };
            Assert.That(() => iter.MacroExpansion(seq, val, newval), Is.EqualTo(expected));
        }
    }
}