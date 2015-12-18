using System;
using System.Linq;

namespace FileImporter.Core
{
    public class NumberSorter
    {
        private int[] _numbers;
        private string _numberString;
        private bool _isValid = false;

        public string Sort(string raw)
        {
            _numberString = raw;
            ValidateInput();
            ExtractNumbers();
            BuildResultString();
            return _numberString;
        }

        private void ValidateInput()
        {
            _isValid = !string.IsNullOrEmpty(_numberString);
        }

        private void ExtractNumbers()
        {
            _numbers = _isValid ? _numberString.Split(',').Select(int.Parse).OrderBy(i => i).ToArray() : new int[0];
        }

        private void BuildResultString()
        {
            _numberString = string.Join(",", _numbers.Select(i => i.ToString()).ToArray());
        }
    }
}
