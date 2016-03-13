using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace FileImporter.Numbers
{

    public class SortedNumbers : Numbers
    {
        private readonly Numbers _origin;

        public SortedNumbers(Numbers numbers)
        {
            _origin = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return GetNumbers().GetEnumerator();
        }

        public ImmutableList<int> GetNumbers()
        {
            return _origin.GetNumbers().OrderBy(i => i).ToImmutableList();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
