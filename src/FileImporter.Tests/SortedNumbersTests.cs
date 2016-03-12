using Should;
using System.Linq;

namespace FileImporter.Tests
{
    public class SortedNumbersTests
    {

        public void ShouldSortNumbers()
        {
            var numbers = new SortedNumbers(
                      new NumbersInText(new TextFromString("3, 1, 10, 7"))
                );

            var expectedSequence = new int[] { 1, 3, 7, 10 };

            numbers.GetNumbers().Count.ShouldEqual(4);
            numbers.GetNumbers().ToArray().SequenceEqual(expectedSequence).ShouldBeTrue();
        }
    }
}
