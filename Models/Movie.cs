using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
   public class Movie
   {
     public int ID { get; set; }
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date"),DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Genre { get; set; } = string.Empty;

        [Range(1,100), DataType(DataType.Currency), Column(TypeName = "decimal(8,2)")]
        [Required]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [StringLength(5)]
        public string Rating { get; set; } = string.Empty;
   }
}