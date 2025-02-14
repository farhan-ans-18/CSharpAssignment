namespace BookCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BooksCollection> books = new List<BooksCollection>
            {
                new BooksCollection("ASPNA", "ASP.Net Professional" , "Wrox", "Bill Evjen, Matt Gibbs", 750.00),
                new BooksCollection("ASPNB", "Beginning ASP .Net" , "TechMedia", "Dan Wahlin, Dave Reed", 545.00),
                new BooksCollection("LNQA", "Learning LINQ" , "APress", "Steve Eichert", 400.00),
                new BooksCollection("CSPN", "C# Developers Guide" , "Tata McGraw", "Dan Maharry", 675.00)

            };

            Console.WriteLine("Enter the Book Code to display the Result");
            Console.WriteLine("The Book Code are:-\nASPNA\nASPNB\nLNQA\nCSPN");
            string bookId = Console.ReadLine().ToUpper();

            var result = from b in books
                         where b.BookCode.Equals(bookId)
                         select b;

            if (result.Count()!=0)
            {
                foreach (var r in result)
                {

                    Console.WriteLine($"{r.BookCode}\t{r.BookName}\t{r.AuthorName}\t{r.PublisherName}\t{r.Price}");
                    Console.WriteLine("------------------------------------------------------");
                }
                
            }
            else
            {
                Console.WriteLine("No Details found");
            }

            Console.WriteLine("Enter two price: ");
            double price1 = double.Parse(Console.ReadLine());
            double price2 = double.Parse(Console.ReadLine());

            var result2 = from b in books
                          where b.Price > price1 && b.Price < price2
                          select b;

            if (result2.Count() != 0)
            {

                foreach (var r2 in result2)
                {

                    Console.WriteLine($"{r2.BookCode}\t{r2.BookName}\t{r2.AuthorName}\t{r2.PublisherName}\t{r2.Price}");
                    Console.WriteLine("---------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No Such Ranges found");
            }


        }
    }

    class BooksCollection
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }

        public string PublisherName { get; set; }

        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BooksCollection(string bookCode, string bookName, string publisherName, string authorName, double price)
        {
            BookCode = bookCode;
            BookName = bookName;
            PublisherName = publisherName;
            AuthorName = authorName;
            Price = price;
        }
    }
}
