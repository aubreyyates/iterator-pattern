namespace IteratorPattern
{
    public class BrowseHistoryList
    {
        private List<string> Urls = new List<string>();

        public void Push(string Url)
        {
            Urls.Add(Url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastURL = Urls[lastIndex];
            Urls.Remove(lastURL);

            return lastURL;
        }

        public Iterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator<string>
        {
            private BrowseHistoryList BrowseHistory;
            private int Index;
            public ListIterator(BrowseHistoryList browseHistory)
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
