using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks() 
        { 
            return new List<Book>
            {
                new Book()  {Name = "Book 1", Price = 10},
                new Book()  {Name = "Book 2", Price = 20},
                new Book()  {Name = "Book 3", Price = 30},
            }; 
        }
    }
}
