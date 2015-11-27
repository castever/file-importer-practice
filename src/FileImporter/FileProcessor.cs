using FileImporter.Core;
using System.IO;

namespace FileImporter
{
    class FileProcessor
    {
        private NumberSorter _numberSorter;
        private string _fileText;

        public void Process()
        {
            ReadFileContents();
            SortFileContents();
            WriteFileContents();
        }

        private void ReadFileContents()
        {
            _fileText = File.ReadAllText(@"C:\_temp\numbers.txt");
        }

        private void WriteFileContents()
        {
            File.WriteAllText(@"C:\_temp\numbers.txt", _fileText);
        }

        private void SortFileContents()
        {
            _fileText = _numberSorter.Sort(_fileText);
        }
    }
}
