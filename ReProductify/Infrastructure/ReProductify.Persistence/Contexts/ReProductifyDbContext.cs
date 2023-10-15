using Microsoft.EntityFrameworkCore;
using ReProductify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReProductify.Persistence.Contexts
{
	public class ReProductifyDbContext :DbContext
	{
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("ReProductifyDb");
		}
	}
}
