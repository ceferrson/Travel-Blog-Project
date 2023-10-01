using Microsoft.EntityFrameworkCore;

namespace TravelTripProject.Models.Classes
{
	public class TravelDbContext : DbContext
	{
		public DbSet<HomePage> HomePages { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Adress> Adresses { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost; Database=TravelDB; Trusted_Connection=True; Encrypt=False");
		}
	}
}
