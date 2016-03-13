namespace FileImporter.Text
{
    using System.IO;

    public class TextFromFile : Text
    {
        private readonly string _url;

        public TextFromFile(string url)
        {
            _url = url; 
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(Read());
        }

        public string Read()
        {
            return File.ReadAllText(_url);
        }
    }
}
