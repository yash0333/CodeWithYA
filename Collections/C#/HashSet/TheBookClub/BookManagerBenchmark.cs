using BenchmarkDotNet.Attributes;

namespace TheBookClub
{
    public class BookManagerBenchmark
    {
        private readonly BookManager_V1 _bookManager_V1;
        private readonly BookManager_V2 _bookManager_V2;

        private readonly string _book;

        public BookManagerBenchmark()
        {
            _bookManager_V1 = new BookManager_V1();
            _bookManager_V2 = new BookManager_V2();

            _book = "Book 80000";
        }

        [GlobalSetup]
        public void AddBooks()
        {
            for (int i = 1; i < 100000; i++)
            {
                var book = $"Book {i}";
                _bookManager_V1.AddBook(book);
                _bookManager_V2.AddBook(book);
            }
        }

        [Benchmark]
        public bool SearchBook_V1()
        {
            return _bookManager_V1.hasBook(_book);
        }

        [Benchmark]
        public bool SearchBook_V2()
        {
            return _bookManager_V2.hasBook(_book);
        }
    }
}