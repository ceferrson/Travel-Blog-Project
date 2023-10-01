using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Models.Classes
{
	public class Adress
	{
		[Key] 
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string OpenAdress { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Location { get; set; }
	}
}
