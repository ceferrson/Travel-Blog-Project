namespace TravelTripProject.Models.Classes
{
	public class BlogComment
	{
		public IEnumerable<Blog> blogValue { get; set; }
		public IEnumerable<Comment> commentValue { get; set; }
	}
}
