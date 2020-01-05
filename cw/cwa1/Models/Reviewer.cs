using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwa1.Models
{
    public class Reviewer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reviewerId {get; set;}
        [Required]
        [MaxLength(100, ErrorMessage = "First Name cannot be more than 100 characters")]
        public string reviewerFirstName {get; set;}
        [Required]
        [MaxLength(200, ErrorMessage = "Last Name cannot be more than 100 characters")]
        public string reviewerLastName {get; set;}
        public virtual ICollection<Review> reviewerReviews {get; set;}
    }
}
