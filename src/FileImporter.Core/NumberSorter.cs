using System;
using System.Linq;

namespace FileImporter.Core
{
    public class NumberSorter
    {
        private int[] _numbers;
        private string _numberString;

        public string Sort(string raw)
        {
            _numberString = raw;
            ExtractNumbers();
            Array.Sort(_numbers);
            BuildResultString();
            return _numberString;
        }

        private void ExtractNumbers()
        {
            _numbers = _numberString.Split(',').Select(int.Parse).ToArray();
        }

        private void BuildResultString()
        {
            _numberString = string.Join(",", _numbers.Select(i => i.ToString()).ToArray());
        }
    }
}
