
namespace TheBookClub
{
    internal class BookManager_V1
    {
        private readonly List<Book> _books;

        internal BookManager_V1()
        {
            _books = new List<Book>();
        }

        internal void AddBook(Book book)
        {
            _books.Add(book);
        }

        internal void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        internal Book SearchBook(string bookId)
        {
            var book = _books.FirstOrDefault(book => book.Id == bookId);

            if (book == null)
            {
                throw new InvalidOperationException($"Book not found with id: {bookId}");
            }

            return book;
        }
    }
}
