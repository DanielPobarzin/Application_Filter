using FiltersApplication.Model;
using FiltersApplication.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FiltersApplication.ViewModel
{
    public class ChartsVM : DataSourceViewModelBase
	{
		private List<FinancialData> _data;
		private Point _panOffset;
		private Size _zoom;
		public ChartsVM()
		{
			this.GetData("chartdata.csv");

			this.Zoom = new Size(3, 1);
			this.PanOffset = new Point(-10000, 0);
		}
		public List<FinancialData> Data
		{
			get
			{
				return _data;
			}
			set
			{
				if (this._data != value)
				{
					this._data = value;
					this.OnPropertyChanged("Data");
				}
			}
		}

		public Point PanOffset
		{
			get
			{
				return _panOffset;
			}
			set
			{
				if (this._panOffset != value)
				{
					this._panOffset = value;
					this.OnPropertyChanged("PanOffset");
				}
			}
		}

		public Size Zoom
		{
			get
			{
				return _zoom;
			}
			set
			{
				if (this._zoom != value)
				{
					this._zoom = value;
					this.OnPropertyChanged("Zoom");
				}
			}
		}

		protected override void GetDataCompleted(IEnumerable data)
		{
			List<FinancialData> list = data as List<FinancialData>;
			this.Data = list;
		}

		protected override IEnumerable ParseData(TextReader dataReader)
		{
			string line;

			List<FinancialData> chartData = new List<FinancialData>();

			while ((line = dataReader.ReadLine()) != null)
			{
				if (string.IsNullOrEmpty(line))
					continue;

				string[] data = line.Split(',');

				FinancialData dataItem = new FinancialData();
				dataItem.Date = DateTime.Parse(data[0], CultureInfo.InvariantCulture);
				dataItem.Close = double.Parse(data[1], CultureInfo.InvariantCulture);
				dataItem.Volume = long.Parse(data[2], CultureInfo.InvariantCulture);

				chartData.Add(dataItem);
			}

			return chartData;
		}
	}
}