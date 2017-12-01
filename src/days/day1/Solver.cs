namespace aoc.days.day1
{
    public class Solver : ISolver
    {
        public int Part1(string s)
        {
            var total = 0;
            var position = 0;

            while (true)
            {
                var prev = s[position];
                var next = (position == s.Length - 1) ? s[0] : s[position + 1];

                if (next == prev)
                    total += int.Parse(next.ToString());

                position++;

                if (position == s.Length)
                    break;
            }

            return total;
        }

        public int Part2(string s)
        {
            var total = 0;
            var position = 0;

            while (true)
            {
                var prev = s[position];

                var nextpos = (position >= s.Length / 2) ? position - (s.Length / 2) : position + (s.Length / 2);
                var next = s[nextpos];

                if (next == prev)
                    total += int.Parse(next.ToString());

                position++;

                if (position == s.Length)
                    break;
            }

            return total;
        }
    }
}