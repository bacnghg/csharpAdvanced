using Generics;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollar);
            var cheapBooks = books.FindAll(book => book.Price > 20); // lambda expression
            foreach (var ibook in cheapBooks)
            {
                Console.WriteLine(ibook.Name);
            }

            // LambdaExpression
            //const int factor = 20;
            //Func<int, int > square = n => n * factor;
            //Console.WriteLine(square(10));
        }

        static bool IsCheaperThan10Dollar(Book book)
        {
            return book.Price > 10;
        }

        static int Square(int number)
        {
            return number*number;
        }
    }
}