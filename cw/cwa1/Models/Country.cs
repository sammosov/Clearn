using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwa1.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int countryId {get; set;}
        [Required]
        [MaxLength(50, ErrorMessage = "Country Name cannot be more than 50 characters")]
        public string countryName {get; set;}
        public virtual ICollection<Author> bookAuthors {get; set;}

    }
}
