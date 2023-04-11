using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Data.Enums;

namespace Ticket_Booking_Website.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Movie Description is Required")]
        public string Description { get; set; }
        
        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Movie price is Required")]
        public double Price { get; set; }
        
        [Display(Name = "Movie Image")]
        [Required(ErrorMessage = "Image is Required")]
        public string ImageURL { get; set; }
        
        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is Required")]
        public DateTime StartDate { get; set; }
        
        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is Required")]
        public DateTime EndDate { get; set; }
        
        [Display(Name = "Select movie Category")]
        [Required(ErrorMessage = "Movie category is Required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is Required")]
        public List<int> ActorIds { get; set; }
        
        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "Movie cinema is Required")]
        public int CinemaId { get; set; }
        
        [Display(Name = "Select producer")]
        [Required(ErrorMessage = "Movie producer is Required")]
        public int ProducerId { get; set; }
    }
}
