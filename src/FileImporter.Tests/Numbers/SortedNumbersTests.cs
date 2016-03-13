using Should;
using System.Linq;

namespace FileImporter.Tests.Numbers
{
    using FileImporter.Numbers;

    public class SortedNumbersTests
    {

        public void ShouldSortNumbers()
        {
            var numbers = new SortedNumbers(
                      new NumbersFromArray(new int[] { 3, 1, 10, 7 })
                );

            var expectedSequence = new int[] { 1, 3, 7, 10 };

            numbers.GetNumbers().Count.ShouldEqual(4);
            numbers.GetNumbers().ToArray().SequenceEqual(expectedSequence).ShouldBeTrue();
        }
    }
}
