using FiltersApplication;
using FiltersApplication.Interfaces;
using FiltersApplication.Model;
using Microsoft.EntityFrameworkCore;
using FiltersApplication.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace FiltersApplication.DbInitializer
{
	public class ApplicationDbFuelContext : DbContext, IFuelsDbContext
	{
		public DbSet<Fuel> Fuels { get; set; }
		public ApplicationDbFuelContext(DbContextOptions<ApplicationDbFuelContext> options)
			: base(options) { }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new FuelConfig());
			base.OnModelCreating(builder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=DataFuels.db");
		}
	}
	public class ApplicationDbFilterContext : DbContext, IFiltersDbContext
	{
        public DbSet<Filter> Filters { get; set; }
		public ApplicationDbFilterContext(DbContextOptions<ApplicationDbFilterContext> options)
			: base(options) {}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new FilterConfig());
			base.OnModelCreating(builder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataFilters.db");
        }
    }
	
}
