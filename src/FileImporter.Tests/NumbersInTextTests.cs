namespace FileImporter.Tests
{
    using Should;

    public class NumbersInTextTests
    {
        public void ShouldParseSimpleText()
        {
            var numbers = new NumbersInText(new TextFromString("1,2,3"));
            numbers.ShouldNotBeEmpty();
            numbers.GetNumbers().Count.ShouldEqual(3);
            numbers.GetNumbers().ShouldContain(1);
            numbers.GetNumbers().ShouldContain(2);
            numbers.GetNumbers().ShouldContain(3);
        }

        public void ShouldParseEmptyText()
        {
            var numbers = new NumbersInText(new TextFromString(""));
            numbers.ShouldBeEmpty();
        }

        public void ShouldParseNonNumbers()
        {
            var numbers = new NumbersInText(new TextFromString("a, b, c, d"));
            numbers.ShouldBeEmpty();
        }

        public void ShouldSkipNonNumbers()
        {
            var numbers = new NumbersInText(new TextFromString("a, 3, c, 2"));
            numbers.ShouldNotBeEmpty();
            numbers.GetNumbers().Count.ShouldEqual(2);
            numbers.GetNumbers().ShouldContain(2);
            numbers.GetNumbers().ShouldContain(3);
        }
    }
}
