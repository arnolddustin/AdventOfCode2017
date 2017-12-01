using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace aoc.days.day2
{
    [TestClass]
    public class Tests
    {
        TestHelper _h = new TestHelper(2, new Solver());

        [TestMethod]
        public void Day2Part1Samples()
        {
            Assert.AreEqual(3, _h.Part1("1122"));
            Assert.AreEqual(4, _h.Part1("1111"));
            Assert.AreEqual(0, _h.Part1("1234"));
            Assert.AreEqual(9, _h.Part1("91212129"));
        }

        [TestMethod]
        public void Day2Part1()
        {
            var expected = 1102;
            var actual = _h.Part1();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Day2Part2Samples()
        {
            Assert.AreEqual(6, _h.Part2("1212"));
            Assert.AreEqual(0, _h.Part2("1221"));
            Assert.AreEqual(4, _h.Part2("123425"));
            Assert.AreEqual(12, _h.Part2("123123"));
            Assert.AreEqual(4, _h.Part2("12131415"));
        }

        [TestMethod]
        public void Day2Part2()
        {
            var expected = 1076;
            var actual = _h.Part2();

            Assert.AreEqual(expected, actual);
        }
    }
}
