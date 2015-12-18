using FileImporter.Core;
using Should;

namespace FileImporter.Tests
{
    public class NumberSorterTests
    {
        private NumberSorter _sorter;

        public NumberSorterTests()
        {
            _sorter = new NumberSorter();
        }

        public void ShouldSortNumbers()
        {
            var unsorted = "3,0,1,5,7,9,4,8,6,2";
            var expected = "0,1,2,3,4,5,6,7,8,9";
            string result = _sorter.Sort(unsorted);
            result.ShouldEqual(expected);
        }

        public void ShouldReturnEmptyStringIfGivenAnEmptyString()
        {
            var unsorted = "";
            var result = _sorter.Sort(unsorted);
            result.ShouldBeEmpty();
        }
    }
}
