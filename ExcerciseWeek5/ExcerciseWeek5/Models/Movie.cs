using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExcerciseWeek5.Models
{
    public class Movie
    {
        [DisplayName("Title")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$", ErrorMessage = "Release Date must be in the format MM/DD/YYYY")]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("ID")]
        public int Id { get; set; }
    }
}
