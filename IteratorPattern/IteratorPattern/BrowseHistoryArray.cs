namespace IteratorPattern
{
    public class BrowseHistoryArray
    {
        private string[] Urls = new string[10];
        private int Count;

        public void Push(string url)
        {
            Urls[Count++] = url;
        }

        public string Pop()
        {
            return Urls[Count--];
        }

        public Iterator<string> CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : Iterator<string>
        {
            private BrowseHistoryArray BrowseHistory;
            private int Index;
            public ArrayIterator(BrowseHistoryArray browseHistory)
            {
                BrowseHistory = browseHistory;
            }

            public string Current()
            {
                return BrowseHistory.Urls[Index];
            }

            public bool HasNext()
            {
                return Index < BrowseHistory.Urls.Count();
            }

            public void Next()
            {
                Index++;
            }
        }
    }
}
