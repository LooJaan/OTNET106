using Microsoft.EntityFrameworkCore;
using Share;

namespace API.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<SinhVien> SinhViens { get; set; }
	}
}
