using BenchmarkDotNet.Attributes;

namespace TheBookClub
{
    public class BookManagerBenchmark
    {
        private readonly BookManager_V1 _bookManager_V1;
        private readonly BookManager_V2 _bookManager_V2;

        private readonly string _bookId;

        public BookManagerBenchmark()
        {
            _bookManager_V1 = new BookManager_V1();
            _bookManager_V2 = new BookManager_V2();

            _bookId = "uid_80000";
        }

        [GlobalSetup]
        public void AddBooks()
        {
            for (int i = 1; i < 100000; i++)
            {
                var book = new Book($"uid_{i}", $"Book {i}", $"Author {i}", i * 200);
                _bookManager_V1.AddBook(book);
                _bookManager_V2.AddBook(book);
            }
        }

        [Benchmark]
        public Book SearchBook_V1()
        {
            return _bookManager_V1.SearchBook(_bookId);
        }

        [Benchmark]
        public Book SearchBook_V2()
        {
            return _bookManager_V2.SearchBook(_bookId);
        }
    }
}