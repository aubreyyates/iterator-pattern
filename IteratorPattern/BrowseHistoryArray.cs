namespace IteratorPattern
{
    /// <summary>
    /// The BrowseHistoryArray class contains urls.
    /// </summary>
    public class BrowseHistoryArray
    {
        /// <summary>
        /// The url storage.
        /// </summary>
        private string[] Urls = new string[10];

        /// <summary>
        /// The counter for the array.
        /// </summary>
        private int Count;

        /// <summary>
        /// Adds a url to the urls.
        /// </summary>
        /// <param name="url">The url to add.</param>
        public void Push(string url)
        {
            Urls[Count++] = url;
        }

        /// <summary>
        /// Removes the last url and returns it.
        /// </summary>
        /// <returns>The last url that was removed.</returns>
        public string Pop()
        {
            return Urls[Count--];
        }

        /// <summary>
        /// Creates an iterator class that can be used to iterate over the urls.
        /// </summary>
        /// <returns>The iterator class.</returns>
        public Iterator<string> CreateIterator()
        {
            return new ArrayIterator(this);
        }

        /// <summary>
        /// The ArrayIterator is a class that provides a way to iterate over the urls with the common iterator pattern.
        /// </summary>
        public class ArrayIterator : Iterator<string>
        {
            /// <summary>
            /// The BrowseHistoryList class.
            /// </summary>
            private BrowseHistoryArray BrowseHistory;

            /// <summary>
            /// The index position in the list.
            /// </summary>
            private int Index;

            /// <summary>
            /// The constructor adds the BrowseHistoryArray class to the iterator.
            /// </summary>
            /// <param name="browseHistory">The BrowseHistoryArray.</param>
            public ArrayIterator(BrowseHistoryArray browseHistory)
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
