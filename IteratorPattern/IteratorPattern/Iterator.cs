namespace IteratorPattern
{
    /// <summary>
    /// The Iterator interface provides a way to iterate over items with the common iterator pattern.
    /// </summary>
    public interface Iterator<T>
    {
        /// <summary>
        /// Returns whether there is a next item in the iterator.
        /// </summary>
        /// <returns>True if there is another item; otherwise, false.</returns>
        public bool HasNext();

        /// <summary>
        /// Returns the current item in the iterator.
        /// </summary>
        /// <returns>The current item.</returns>
        public T Current();

        /// <summary>
        /// Increments the iterator index so the next item can be obtained.
        /// </summary>
        public void Next();
    }
}
