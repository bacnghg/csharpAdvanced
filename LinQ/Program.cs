using Generics;

namespace LinQ
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 50)
            //        cheapBooks.Add(book);
            //}

            //var bok = books.FirstOrDefault(b => b.Name == "Black 5");
            //Console.WriteLine(bok.Price);

            var bok = books.Skip(3).Take(5);
            foreach (var b in bok)
            {
                Console.WriteLine(b.Name + ": " + b.Price);
            }

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            // LINQ Query Operators
            var cheaperBooks = from book in books
                               where book.Price < 70
                               orderby book.Name
                               select book.Name;

            // LINQ Extension Methods
            var cheapBooks = books
                             .Where(b => b.Price < 70)
                             .OrderBy(b => b.Name)
                             .Select(b => b.Name);

            foreach (var cheapBook in cheaperBooks)
                Console.WriteLine(cheapBook);
        }
    }
}