using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Models.Classes
{
	public class Contact
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}
