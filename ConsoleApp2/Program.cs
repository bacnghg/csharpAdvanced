namespace Generics
{
 
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { BookId = 1100, Name = "C# Advanced" };

            ////var numbers = new List<int>();
            ////numbers.Add(1);

            ////var books = new BookList();
            ////books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<int, Book>();
            //dictionary.Add(100, new Book());

            //var number = new Nullable<int>(5);
            var number = new Nullable<int>();
            Console.WriteLine("has value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}