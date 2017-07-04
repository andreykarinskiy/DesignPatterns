using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> AsRandom<T>(this T[] source)
        {
            var indexes = GenerateRandomSequence(source.Length);

            foreach (var i in indexes)
            {
                yield return source[i];
            }
        }

        private static int[] GenerateRandomSequence(int total)
        {
            var random = new Random();

            var sequence = new HashSet<int>();

            while (sequence.Count < total)
            {
                sequence.Add(random.Next(0, total));
            }

            return sequence.ToArray();
        }
    }
}