using System;
using System.Collections.Generic;

namespace cwa1.Models
{
    public class book
    {
        public int bookId {get; set;}
        public string bookIsbn {get; set;}
        public string bookTitle {get; set;}
        public DateTime bookDatePublished {get; set;}
        
        public virtual ICollection<Review> bookReviews {get; set;}
        public virtual ICollection<BookAuthor> bookAuthors {get; set;}
        public virtual ICollection<BookCategory> categoryBooks {get; set;}
}
