using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace FiltersApplication.Model
{
	public sealed class GlobalSingletonFilterModel :  INotifyPropertyChanged
	{
		private GlobalSingletonFilterModel() { }
		private Filter _selectedFilter;
		private Station _currentParametersStation;
		private ObservableCollection<Fuel> _selectedFuels;
		private static readonly Lazy<GlobalSingletonFilterModel> lazy =
		new Lazy<GlobalSingletonFilterModel>(() => new GlobalSingletonFilterModel());
		public static GlobalSingletonFilterModel Instance { get { return lazy.Value; } }

		public ObservableCollection<Fuel> SelectedFuels
		{
			get { return _selectedFuels; }
			set
			{
				_selectedFuels = value;
				OnPropertyChanged(nameof(SelectedFuels));
			}
		}
		public Filter SelectedFilter
		{
			get { return _selectedFilter; }
			set
			{
				_selectedFilter = value;
				OnPropertyChanged(nameof(SelectedFilter));
			}
		}
		public Station CurrentParametersStation
		{
			get { return _currentParametersStation; }
			set
			{
				_currentParametersStation = value;
				OnPropertyChanged(nameof(CurrentParametersStation));
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
