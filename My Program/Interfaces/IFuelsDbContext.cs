using FiltersApplication.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FiltersApplication.Interfaces
{
	public interface IFuelsDbContext
	{
		DbSet<Fuel> Fuels { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
