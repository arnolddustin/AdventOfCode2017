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
            Assert.AreEqual(18, _h.RunPart1("5\t1\t9\t5", "7\t5\t3", "2\t4\t6\t8"));
        }

        [TestMethod]
        public void Day2Part1()
        {
            Assert.AreEqual(53460, _h.SolvePart1());
        }

        [TestMethod]
        public void Day2Part2Samples()
        {
            Assert.AreEqual(9, _h.RunPart2("5\t9\t2\t8", "9\t4\t7\t3", "3\t8\t6\t5"));
        }

        [TestMethod]
        public void Day2Part2()
        {
            Assert.AreEqual(282, _h.SolvePart2());
        }
    }
}
