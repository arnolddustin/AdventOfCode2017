using System.IO;
using System.Linq;

namespace aoc
{
    public class TestHelper
    {
        ISolver _solver;
        int? _day;

        public TestHelper(int? dayNumber, ISolver solver)
        {
            _day = dayNumber;
            _solver = solver;
        }

        public string InputSingleLine()
        {
            return InputAllLines().First();
        }
        public string[] InputAllLines()
        {
            return File.ReadAllLines(string.Format("../../../days/day{0}/input.txt", _day));
        }

        public int Part1()
        {
            return Part1(InputSingleLine());
        }
        public int Part1(string s)
        {
            return _solver.Part1(s);
        }

        public int Part2()
        {
            return Part2(InputSingleLine());
        }
        public int Part2(string s)
        {
            return _solver.Part2(s);
        }
    }
}