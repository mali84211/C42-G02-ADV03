namespace C42_G02_ADV03
{
    public delegate string BookDelegate(Book book);

    public class BookProcessor
    {
        public static void ProcessBooks(List<Book> books, BookDelegate bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }

        public static void ProcessBooks(List<Book> books, Func<Book, string> bookFunc)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookFunc(book));
            }
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            List<Book> books = new List<Book>
            {
                 new Book("1", "Book1", new[] { "Author1", "Author2" }, new DateTime(1999, 1, 31), 29.99m),
                 new Book("2", "Book2", new[] { "Author3", "Author4" }, new DateTime(2024, 8, 10), 49.99m)
            };
                BookProcessor.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));
                BookProcessor.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetAuthors));
                LibraryEngine.ProcessBooks(books, delegate (Book book) { return book.ISBN; });
                LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToShortDateString());
            #endregion

            Console.WriteLine("==========================");

            #region part2
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            bool exists = myList.Exists(x => x == 3);
            Console.WriteLine($"Exists: {exists}"); 

            int found = myList.Find(x => x == 3);
            Console.WriteLine($"Found: {found}"); 

            List<int> foundAll = myList.FindAll(x => x > 2);
            Console.WriteLine($"FoundAll: {string.Join(", ", foundAll)}"); 

            int findIndex = myList.FindIndex(x => x == 2);
            Console.WriteLine($"FindIndex: {findIndex}"); 

            int findLastIndex = myList.FindLastIndex(x => x == 3);
            Console.WriteLine($"FindLastIndex: {findLastIndex}");

            Console.WriteLine($"ForEach: ");
            myList.ForEach(x => Console.WriteLine(x)); 

            bool trueForAll = myList.TrueForAll(x => x > 0);
            Console.WriteLine($"TrueForAll: {trueForAll}");
            #endregion
        }
    }
}
