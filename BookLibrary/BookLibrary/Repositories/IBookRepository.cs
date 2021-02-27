using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookLibrary.Repositories
{
    public interface IBookRepository
    {
        void CreateBookAsync(Book book);
        void UpdateBookAsync(Book book);
        void DeleteBookAsync(Book book);
        void DeleteAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task<List<Book>> GetAllBooksAsync(int afterId = 0);
        Task<List<Book>> GetBooksByNameAsync(string name, int afterId = 0);
        Task<List<Book>> GetBooksByThemeAsync(string theme, int afterId = 0);
        Task<List<Book>> GetBooksByDateAsync(DateTime publisheDate);

    }
}