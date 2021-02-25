using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author{ get; set; }
        public double Price{ get; set; }
        public DateTime PublishedDate  { get; set; }
        public string Photo { get; set; }
        public string Theme { get; set; }
    }
}