using IteratorPattern;

Iterator<string> iterator;

// Instantiate a class to hold our browse history. It will use a list to contain urls.
BrowseHistoryList browseHistoryList = new BrowseHistoryList();

// Add url history to our browse history.
browseHistoryList.Push("https://www.google.com");
browseHistoryList.Push("https://www.facebook.com");
browseHistoryList.Push("https://www.youtube.com");

// Print our history by iterating over each url.
iterator = browseHistoryList.CreateIterator();
while(iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}

// Simultate a change in the class that contains our browse history. In the new class, it will use an array instead of
// a list to contain our urls.
BrowseHistoryArray browseHistoryArray = new BrowseHistoryArray();
browseHistoryList.Push("https://www.google.com");
browseHistoryList.Push("https://www.facebook.com");
browseHistoryList.Push("https://www.youtube.com");

// Print our history without needing to make any changes to the code that uses the class.
iterator = browseHistoryArray.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}