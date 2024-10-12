
namespace TheBookClub
{
    internal class BookManager_V1
    {
        private readonly List<string> _books;

        internal BookManager_V1()
        {
            _books = new List<string>();
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
