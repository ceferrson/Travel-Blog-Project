using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Models.Classes
{
	public class Comment
	{
		[Key]
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Comments { get; set; }
		public int BlogId { get; set; }
		public virtual Blog Blog { get; set; }
	}
}
