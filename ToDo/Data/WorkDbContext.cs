using Microsoft.EntityFrameworkCore;
using ToDo.Data.Models;

namespace ToDo.Data
{
	public class WorkDbContext:DbContext
	{
		public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options) 
		{

		}
		public DbSet<Work> Works { get; set; }

	}
}
