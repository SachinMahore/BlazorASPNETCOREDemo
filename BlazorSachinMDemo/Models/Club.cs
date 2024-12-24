using System.ComponentModel.DataAnnotations;

namespace BlazorSachinMDemo.Models
{
    public class Club
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Club Name is mandatory")]
        public string ClubName { get; set; }
        public string YearFounded { get; set; }
        public string Country { get; set; }
    }
}
