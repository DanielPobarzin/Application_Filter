using FiltersApplication.Model;
using FiltersApplication.Utilities;
using FiltersApplication.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;
using System.Windows.Input;

namespace FiltersApplication.ViewModel
{
    class NavigationVM : ViewModelBase
    {
		private Dictionary<Type, UserControl> _userControlCache = new Dictionary<Type, UserControl>();
		private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand FiltersCommand { get; set; }
        public ICommand FuelsCommand { get; set; }
        public ICommand StationsCommand { get; set; }
        public ICommand CalculateCommand { get; set; }
        public ICommand ChartsCommand { get; set; }

		private async void HomeAsync(object obj)
		{
			CurrentView = await GetViewModelInstanceAsync(typeof(View.Home));
		}
		private async void FilterAsync(object obj)
	{
		CurrentView = await GetViewModelInstanceAsync(typeof(View.Filters));
	}
		private async void FuelAsync(object obj)
		{
			CurrentView = await GetViewModelInstanceAsync(typeof(View.Fuels));
		}
		private async void StationAsync(object obj)
		{
			CurrentView = await GetViewModelInstanceAsync(typeof(View.Stations));
		}
		private async void CalculateAsync(object obj)
		{
			CurrentView = await GetViewModelInstanceAsync(typeof(View.Calculate));
		}

		private async void ChartAsync(object obj)
		{
			CurrentView = await GetViewModelInstanceAsync(typeof(View.Charts));
		}

		public NavigationVM()
		{
			HomeCommand = new RelayCommand(HomeAsync);
			FiltersCommand = new RelayCommand(FilterAsync);
			FuelsCommand = new RelayCommand(FuelAsync);
			StationsCommand = new RelayCommand(StationAsync);
			CalculateCommand = new RelayCommand(CalculateAsync);
			ChartsCommand = new RelayCommand(ChartAsync);
			InitializeCurrentView();
		}
		private void InitializeCurrentView()
		{
			CurrentView = _userControlCache.ContainsKey(typeof(View.Home)) ? _userControlCache[typeof(View.Home)] : new HomeVM();
		}
		private async Task<UserControl> GetViewModelInstanceAsync(Type viewType)
		{
			if (!_userControlCache.ContainsKey(viewType))
			{
				UserControl view = (UserControl)Activator.CreateInstance(viewType);
				_userControlCache[viewType] = view;
			}
			return await Task.FromResult(_userControlCache[viewType]);
		}
	}
}



