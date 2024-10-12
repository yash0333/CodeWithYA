
namespace TheBookClub
{
    internal class BookManager_V2
    {
        private readonly HashSet<string> _books;

        internal BookManager_V2()
        {
            _books = new HashSet<string>();
        }

        internal void AddBook(string book)
        {
            _books.Add(book);
        }

        internal void RemoveBook(string book)
        {
            _books.Remove(book);
        }

        internal bool hasBook(string book)
        {
            return _books.Contains(book);
        }

        internal string GetBooks()
        {
            return string.Join(",", _books);
        }
    }
}
