namespace IteratorPattern
{
    /// <summary>
    /// The BrowseHistoryArray class contains urls.
    /// </summary>
    public class BrowseHistoryList
    {
        /// <summary>
        /// The url storage.
        /// </summary>
        private List<string> Urls = new List<string>();

        /// <summary>
        /// Adds a url to the urls.
        /// </summary>
        /// <param name="url">The url to add.</param>
        public void Push(string Url)
        {
            Urls.Add(Url);
        }

        /// <summary>
        /// Removes the last url and returns it.
        /// </summary>
        /// <returns>The last url that was removed.</returns>
        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastURL = Urls[lastIndex];
            Urls.Remove(lastURL);

            return lastURL;
        }

        /// <summary>
        /// Creates an iterator class that can be used to iterate over the urls.
        /// </summary>
        /// <returns>The iterator class.</returns>
        public Iterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        /// <summary>
        /// The ListIterator is a class that provides a way to iterate over the urls with the common iterator pattern.
        /// </summary>
        public class ListIterator : Iterator<string>
        {
            /// <summary>
            /// The BrowseHistoryList class.
            /// </summary>
            private BrowseHistoryList BrowseHistory;

            /// <summary>
            /// The index position in the list.
            /// </summary>
            private int Index;

            /// <summary>
            /// The constructor adds the BrowseHistoryList class to the iterator.
            /// </summary>
            /// <param name="browseHistory">The BrowseHistoryList.</param>
            public ListIterator(BrowseHistoryList browseHistory)
            {
                BrowseHistory = browseHistory;
            }

            /// <summary>
            /// Returns the current url in the iterator.
            /// </summary>
            /// <returns>The current url.</returns>
            public string Current()
            {
                return BrowseHistory.Urls[Index];
            }

            /// <summary>
            /// Returns whether there is a next url in the iterator.
            /// </summary>
            /// <returns>True if there is another url; otherwise, false.</returns>
            public bool HasNext()
            {
                return Index < BrowseHistory.Urls.Count();
            }

            /// <summary>
            /// Increments the iterator index so the next url can be obtained.
            /// </summary>
            public void Next()
            {
                Index++;
            }
        }
    }
}
