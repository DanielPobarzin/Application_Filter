using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Model.Notes;
using FiltersApplication.Model;

namespace FiltersApplication.Config
{
	public class FuelConfig : IEntityTypeConfiguration<Fuel>
	{
		public void Configure(EntityTypeBuilder<Fuel> builder)
		{
			builder.HasKey(fuel => fuel.ID);
			builder.HasIndex(fuel => fuel.ID).IsUnique();
			builder.Property(fuel => fuel.BrandFuel).HasMaxLength(250);

		}
	}
}
