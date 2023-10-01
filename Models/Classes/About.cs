using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Models.Classes
{
	public class About
	{
        [Key]
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
    }
}
