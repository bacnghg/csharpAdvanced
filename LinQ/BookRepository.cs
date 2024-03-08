using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Name="Anz 1", Price = 100},
                new Book() {Name="Book 2", Price = 20},
                new Book() {Name="QA 3", Price = 30},
                new Book() {Name="Dev 4", Price = 40},
                new Book() {Name="Black 5", Price = 501},
                new Book() {Name="Black 5", Price = 50},
                new Book() {Name="Black 5", Price = 510},
                new Book() {Name="REd 6", Price = 60},
                new Book() {Name="Wridte 7", Price = 70},
                new Book() {Name="Sharker 8", Price = 80},
                new Book() {Name="Bitcoin 9", Price = 90},
            };
        }
    }
}
