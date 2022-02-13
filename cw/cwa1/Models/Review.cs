using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwa1.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reviewId {get; set;}
        [Required]
        [StringLength(200,MinimumLength=10, ErrorMessage = "Head Line must be between 10 to 200 characters")]
        public string reviewHeadLine {get; set;}
        [Required]
        [StringLength(2000,MinimumLength=50, ErrorMessage = "Review Text must be between 50 to 2000 characters")]
        public string reviewReviewText {get; set;}
        [Required]
        [Range(1,5,ErrorMessage = "rating must be between one and five stars")]
        public int reviewRating {get; set;}

        public virtual Reviewer reviewReviewer {get; set;}
        public virtual book reviewBook {get; set;}

    }
}
