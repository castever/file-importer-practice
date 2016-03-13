using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace FileImporter.Numbers
{
    public class NumbersFromArray : Numbers
    {
        private readonly int[] _numbers;

        public NumbersFromArray(int[] numbers)
        {
            _numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _numbers.ToList().GetEnumerator();
        }

        public ImmutableList<int> GetNumbers()
        {
            return _numbers.ToImmutableList();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
