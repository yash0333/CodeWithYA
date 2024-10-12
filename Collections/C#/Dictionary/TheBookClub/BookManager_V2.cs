
namespace TheBookClub
{
    internal class BookManager_V2
    {
        private readonly IDictionary<string, Book> _books;

        internal BookManager_V2()
        {
            _books = new Dictionary<string, Book>();
        }

        internal void AddBook(Book book)
        {
            _books.Add(book.Id, book);
        }

        internal void RemoveBook(Book book)
        {
            _books.Remove(book.Id);
        }

        internal Book SearchBook(string bookId)
        {
            if (_books.TryGetValue(bookId, out Book book))
            {
                return book;
            } 
            else 
            {
                throw new InvalidOperationException($"Book not found with id: {bookId}");
            }
        }
    }
}
