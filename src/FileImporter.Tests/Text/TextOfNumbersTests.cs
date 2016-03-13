using Should;

namespace FileImporter.Tests.Text
{
    using FileImporter.Text;
    using FileImporter.Numbers;

    public class TextOfNumbersTests
    {

        public void ShouldHandleNumbers()
        {
            var text = new NumbersText(
                new NumbersFromArray(new int[] { 1, 2, 3 }));

            text.Read().ShouldEqual("1,2,3");
        }
    }
}
