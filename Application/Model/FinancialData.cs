using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApplication.Model
{
		public class FinancialData
		{
			public DateTime Date { get; set; }

			public double Close { get; set; }

			public long Volume { get; set; }
		}
}
