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

        string[] ReadInput()
        {
            return File.ReadAllLines(string.Format("../../../days/day{0}/input.txt", _day));
        }

        public int SolvePart1()
        {
            return RunPart1(ReadInput());
        }
        public int RunPart1(params string[] s)
        {
            return _solver.Part1(s);
        }

        public int SolvePart2()
        {
            return RunPart2(ReadInput());
        }
        public int RunPart2(params string[] s)
        {
            return _solver.Part2(s);
        }
    }
}