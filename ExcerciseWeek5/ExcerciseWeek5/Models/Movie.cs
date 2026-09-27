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
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("ID")]
        public int Id { get; set; }
    }
}
