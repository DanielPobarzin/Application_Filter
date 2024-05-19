using FiltersApplication.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Model.Notes;

namespace FiltersApplication.Interfaces
{
	public interface IFiltersDbContext
	{
		DbSet<Filter> Filters { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
