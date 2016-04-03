using System;
using NUnit.Framework;
using StringDiff;

namespace UnitTestProject1
{
    [TestFixture]
    public class StringDiffTest
    {
        [Test]
        public void Should_Find_Pattern_In_String()
        {
            string str = "BCBAABACAABABACAA";
            string pattern = "ABABAC";

            var kmpPlus = new KMPplus(pattern);
            var result = kmpPlus.search(str);

            Assert.AreEqual(9,result);
        }

        [Test]
        public void Should_Not_Find_Pattern_In_String()
        {
            string str = "BCBAABACAABABACAA";
            string pattern = "WXYZ";

            var kmpPlus = new KMPplus(pattern);
            var result = kmpPlus.search(str);

            Assert.AreEqual(-1, result);
        }
    }
}
