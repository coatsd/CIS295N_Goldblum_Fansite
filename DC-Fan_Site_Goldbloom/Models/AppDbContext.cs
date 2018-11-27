using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.DependencyInjection;
using DC_Fan_Site_Goldbloom.Models.Repositories;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) 
			: base(options)
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<Reply> Replies { get; set; }
		public DbSet<Story> Stories { get; set; }
		public DbSet<Media> Medias { get; set; }
		public DbSet<Book> Books { get; set; }
	}
}
