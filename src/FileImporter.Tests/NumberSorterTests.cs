using FileImporter.Core;
using Should;

namespace FileImporter.Tests
{
    public class NumberSorterTests
    {

        public void ShouldSortNumbers()
        {
            var unsorted = "3,0,1,5,7,9,4,8,6,2";
            var expected = "0,1,2,3,4,5,6,7,8,9";
            NumberSorter sorter = new NumberSorter();
            string result = sorter.Sort(unsorted);
            result.ShouldEqual(expected);
        }
    }
}
