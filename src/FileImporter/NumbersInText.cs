using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace FileImporter
{
    public class NumbersInText : Numbers
    {
        private readonly ImmutableList<int> _numbers;

        public NumbersInText(Text text)
        {
            _numbers = text.isEmpty() ?
                 new List<int>().ToImmutableList()
                : text.Read()
                .Split(',')
                .Where(i =>
               {
                   int n;
                   return int.TryParse(i, out n);
               })
                .Select(int.Parse)
                .ToImmutableList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _numbers.GetEnumerator();
        }

        public ImmutableList<int> GetNumbers()
        {
            return _numbers;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
