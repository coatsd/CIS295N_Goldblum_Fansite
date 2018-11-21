using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class BookTestRepository
    {
        private List<Book> books = new List<Book>();

        public List<Book> Books { get { return books; } }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
