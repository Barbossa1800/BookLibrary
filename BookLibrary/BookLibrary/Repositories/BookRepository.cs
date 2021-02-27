using BookLibrary.Contexts;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        BookContext db;
        public BookRepository()
        {
            db = new BookContext();        
        }
        public void CreateBookAsync(Book book)
        {
            db.Books.AddAsync(book);
            db.SaveChangesAsync();
        }

        public async void DeleteAllBooksAsync()
        {
            var booksForDelete = await db.Books.ToListAsync();
            db.Books.RemoveRange(booksForDelete);
            await db.SaveChangesAsync();
        }

        public void DeleteBookAsync(Book book)
        {
            db.Books.Remove(book);
            db.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAllBooksAsync(int afterId)
        {
            return await db.Books
                .Where(d => d.Id < afterId)
                .OrderBy(d => d.Id)
                .ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await db.Books.SingleOrDefaultAsync(d =>d.Id == id);
        }

        public async Task<List<Book>> GetBooksByDateAsync(DateTime publisheDate)
        {
            return await db.Books
                .Where(d => d.PublishedDate.Year == publisheDate.Year && d.PublishedDate.Month == publisheDate.Month && d.PublishedDate.Day == publisheDate.Day)
                .OrderBy(d => d.Id)
                .ToListAsync();
        }

        public async Task<List<Book>> GetBooksByNameAsync(string name, int afterId)
        {
            return await db.Books
                .Where(d => d.Name.Contains(name) && d.Id > afterId)
                .OrderBy(d => d.Id)
                .ToListAsync();
        }

        public async Task<List<Book>> GetBooksByThemeAsync(string theme, int afterId)
        {
            return await db.Books
                .Where(d => d.Theme.Contains(theme) && d.Id > afterId)
                .OrderBy(d => d.Id)
                .ToListAsync();
        }

        public void UpdateBookAsync(Book book)
        {
            db.Books.Update(book);
            db.SaveChangesAsync();
        }

    }
}
