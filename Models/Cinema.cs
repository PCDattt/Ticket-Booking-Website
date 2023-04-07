using System.ComponentModel.DataAnnotations;
using Ticket_Booking_Website.Data.Base;

namespace Ticket_Booking_Website.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display (Name = "Cinema Name")]
        public string Name { get; set; }
        [Display (Name = "Description")]
        public string Description { get; set; }

        //Relationship
         public List<Movie> Movies { get; set; }
    }
}
