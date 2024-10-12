using BenchmarkDotNet.Running;

namespace TheBookClub
{
    internal class Program
    {
        private static BookManager_V2 _bookManager = new();

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BookManagerBenchmark>();
            Console.WriteLine(summary);

            Console.ReadKey();
        }
    }
}
