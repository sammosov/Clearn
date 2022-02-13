using System;

namespace cwa1.Models
{
    public class BookAuthor
    {
        public int bookId {get; set;}
        public book Book {get; set;}
        public int authorId {get; set;}
        public Author Author {get; set;}
    }
}
