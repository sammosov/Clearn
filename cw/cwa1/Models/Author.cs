using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwa1.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int authorId {get; set;}
        [Required]
        [MaxLength(100, ErrorMessage = "First Name cannot be more than 100 characters")]
        public string authorFirstName {get; set;}
        [Required]
        [MaxLength(200, ErrorMessage = "First Name cannot be more than 200 characters")]
        public string authorLastName {get; set;}
        public virtual Country authorCountry {get; set;}
        public virtual ICollection<BookAuthor> bookAuthors {get; set;}

    }
}
