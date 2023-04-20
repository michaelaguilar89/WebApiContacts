using Microsoft.EntityFrameworkCore;

namespace WebApIContacts.Models
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Contact> contact { get; set; }
	}
}
