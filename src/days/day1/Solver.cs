namespace aoc.days.day1
{
    public class Solver : ISolver
    {
        public int Part1(params string[] s)
        {
            var input = s[0];
            var total = 0;
            var position = 0;

            while (true)
            {
                var prev = input[position];
                var next = (position == input.Length - 1) ? input[0] : input[position + 1];

                if (next == prev)
                    total += int.Parse(next.ToString());

                position++;

                if (position == input.Length)
                    break;
            }

            return total;
        }

        public int Part2(params string[] s)
        {
            var input = s[0];
            var total = 0;
            var position = 0;

            while (true)
            {
                var prev = input[position];

                var nextpos = (position >= input.Length / 2) ? position - (input.Length / 2) : position + (input.Length / 2);
                var next = input[nextpos];

                if (next == prev)
                    total += int.Parse(next.ToString());

                position++;

                if (position == input.Length)
                    break;
            }

            return total;
        }
    }
}