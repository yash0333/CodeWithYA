

namespace TheBookClub
{
    public class Book
    {
        public string Id { get; }

        public string Title { get; }

        public string Author { get; }

        public int Price { get; set; }

        public string Status { get; set; }

        public Book(string id, string title, string author, int price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
            Status = "Available";
        }
    }
}