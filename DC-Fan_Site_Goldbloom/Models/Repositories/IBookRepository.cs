using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public interface IBookRepository
    {
        List<Book> Books { get; }

        void AddBook(Book book);
    }
}
