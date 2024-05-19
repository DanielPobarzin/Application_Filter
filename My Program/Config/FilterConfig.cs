using FiltersApplication.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApplication
{
	public class FilterConfig : IEntityTypeConfiguration<Filter>
	{
		public void Configure(EntityTypeBuilder<Filter> builder)
		{
			builder.HasKey(filter => filter.ID);
			builder.HasIndex(filter => filter.ID).IsUnique();
			builder.Property(filter => filter.BrandFilter).HasMaxLength(250);

		}
	}
}
