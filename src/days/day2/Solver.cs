using System.Collections;
using System.Collections.Generic;

namespace aoc.days.day2
{
    public class Solver : ISolver
    {
        public int Part1(params string[] s)
        {
            var total = 0;

            var a = new List<int>();

            foreach (var row in s)
            {
                var cols = row.Split("\t");
                var ints = new List<int>();

                foreach (var col in cols)
                {
                    ints.Add(int.Parse(col));
                }

                ints.Sort();
                total += ints[ints.Count - 1] - ints[0];
            }

            return total;
        }

        public int Part2(params string[] s)
        {
            var total = 0;

            foreach (var row in s)
            {
                var cols = row.Split("\t");
                var ints = new List<int>();

                foreach (var col in cols)
                    ints.Add(int.Parse(col));

                ints.Sort();

                var rowdone = false;
                for (var i = ints.Count - 1; i > 0; i--)
                {
                    for (var j = 0; j < i; j++)
                    {
                        if (ints[i] % ints[j] == 0)
                        {
                            total += ints[i] / ints[j];
                           rowdone = true;
                           break;
                        }
                    }
                        if (rowdone) break;
                }
            }

            return total;
        }
    }
}