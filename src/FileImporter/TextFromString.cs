namespace FileImporter
{
    public class TextFromString : Text
    {
        private readonly string _content;

        public TextFromString(string content)
        {
            _content = content;
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(_content);
        }

        public string Read()
        {
            return _content;
        }
    }
}
