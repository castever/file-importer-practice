using System.Linq;

namespace FileImporter.Text
{
    using Numbers;

    public class NumbersText : Text
    {
        private readonly Numbers _numbers;

        public NumbersText(Numbers numbers)
        {
            _numbers = numbers;
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(Read());
        }

        public string Read()
        {
            return string.Join(",", _numbers.GetNumbers().ToArray());
        }
    }
}
