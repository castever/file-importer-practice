namespace FileImporter
{
    using Text;
    using Numbers;
    using File;

    class Program
    {
        static void Main(string[] args)
        {
            const string url = @"D:\_temp\numbers.txt";
            (new TextFile(url,
                new NumbersText(
                    new SortedNumbers(
                        new NumbersFromText(
                            new TextFromFile(url)))))).Write();
        }
    }
}
 