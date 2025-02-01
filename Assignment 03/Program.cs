namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> {
                new Book("1", "1984", new string[] { "George Orwell" }, new DateTime(1949, 6, 8), 7.99m),
                new Book("2", "The Lord of the Rings", new string[] { "J.R.R. Tolkien" }, new DateTime(1954, 7, 29), 20),
                new Book("3", "The Martian", new string[] { "Andy Weir" }, new DateTime(2014, 2, 11), 15.99m),
                new Book("4", "The Three-Body Problem", new string[] { "Liu Cixin, Ken Liu" }, new DateTime(2014, 11, 11), 11.99m),
                new Book("5", "To Kill a Mockingbird", new string[] { "Harper Lee" }, new DateTime(1960, 7, 11), 8.99m)
            };

            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });

            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToString());
        }
    }
}
