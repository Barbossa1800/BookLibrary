using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
        public string Photo { get; set; }
        [Required]
        public string Theme { get; set; }

        public Book(string name, string author, string theme)
        {
            Name = name;
            Author = author;
            Theme = theme;
        }
    }
}