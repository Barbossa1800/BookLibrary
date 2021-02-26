using BookLibrary.Models;
using BookLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookLibrary.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public async void CreateBookTestAsync()
        {
            IBookRepository bookRep = new BookRepository();
            bookRep.CreateBookAsync(new Book("DUT","Ukraine","Infinity war"));

            var books = await bookRep.GetBooksByNameAsync("DUT", 0);

            Assert.NotNull(books);
        }
        [Fact]
        public async void GetBooksByDateTestAsync()
        {
            IBookRepository bookRep = new BookRepository();
            var books = await bookRep.GetBooksByDateAsync(DateTime.Today);
            Assert.NotNull(books);
        }
    }
}
