using System.ComponentModel.DataAnnotations;
using Ticket_Booking_Website.Data.Base;

namespace Ticket_Booking_Website.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
		[Required(ErrorMessage = "Profile Picture is required")]
		public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		[Required(ErrorMessage = "Full Name is required")]
		[StringLength(50, MinimumLength = 4, ErrorMessage = "Full Name must be between 4 and 50 chars")]
		public string FullName { get; set; }

		[Display(Name = "Biography")]
		[Required(ErrorMessage = "Biography is required")]
		public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
