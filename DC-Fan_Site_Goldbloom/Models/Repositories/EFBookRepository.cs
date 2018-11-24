using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class EFBookRepository : IBookRepository
	{
        private AppDbContext context;

        public EFBookRepository(AppDbContext cxt)
        {
            context = cxt;
        }

        public List<Book> Books { get { return context.Books.ToList(); } }

        public void AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void CreateTestData(int cap)
        {

        }
	}
}
