using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class BookTestRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public List<Book> Books { get { return books; } }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void CreateTestData(int cap)
        {
            for (int i = 0; i < cap; i++)
            {
                Book book = new Book
                {
                    BookID = i,
                    Title = "Title for book " + i,
                    Author = "Author for book " + i,
                    Genre = "Genre for book " + i,
                    Link = "Link for book " + i,
                    Publisher = "Publisher for book " + i,
                    PubDate = "Publish Date for book " + i
                };
                books.Add(book);
            }
        }
    }
}
