using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace aoc.days.day1
{
    [TestClass]
    public class Tests
    {
        TestHelper _h = new TestHelper(1, new Solver());

        [TestMethod]
        public void Day1Part1Samples()
        {
            Assert.AreEqual(3, _h.RunPart1("1122"));
            Assert.AreEqual(4, _h.RunPart1("1111"));
            Assert.AreEqual(0, _h.RunPart1("1234"));
            Assert.AreEqual(9, _h.RunPart1("91212129"));
        }

        [TestMethod]
        public void Day1Part1()
        {
            var expected = 1102;
            var actual = _h.SolvePart1();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Day1Part2Samples()
        {
            Assert.AreEqual(6, _h.RunPart2("1212"));
            Assert.AreEqual(0, _h.RunPart2("1221"));
            Assert.AreEqual(4, _h.RunPart2("123425"));
            Assert.AreEqual(12, _h.RunPart2("123123"));
            Assert.AreEqual(4, _h.RunPart2("12131415"));
        }

        [TestMethod]
        public void Day1Part2()
        {
            var expected = 1076;
            var actual = _h.SolvePart2();

            Assert.AreEqual(expected, actual);
        }
    }
}
