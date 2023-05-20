using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int PublicationYear { get; set; }
        public Book()
        {
                
        }

        public Book(int id, string name, string author, string language, string publisher, string genre, int count, int page, int publicationYear)
        {
            Id = id;
            Name = name;
            Author = author;
            Language = language;
            Publisher = publisher;
            Genre = genre;
            Count = count;
            Page = page;
            PublicationYear = publicationYear;
        }
    }
}
