namespace FileImporter.File
{
    using System.IO;
    using Text;

    public  class TextFile
    {
        private readonly string _url;
        private readonly Text _text;

        public TextFile(string url, Text text)
        {
            _url = url;
            _text = text;
        }

        public void Write()
        {
            File.WriteAllText(_url, _text.Read());
        }

    }
}
