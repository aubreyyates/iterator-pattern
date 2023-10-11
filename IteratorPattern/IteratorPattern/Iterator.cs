namespace IteratorPattern
{
    public interface Iterator<T>
    {
        public bool HasNext();
        public T Current();
        public void Next();
    }
}
