using FiltersApplication.Model;
using FiltersApplication.Utilities;
using FiltersApplication.View;
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

		private async Task NavigateAsync(Type viewType)
		{
			CurrentView = await GetViewModelInstanceAsync(viewType);
		}
		public NavigationVM()
		{
			HomeCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Home)));
			FiltersCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Filters)));
			FuelsCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Fuels)));
			StationsCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Stations)));
			CalculateCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Calculate)));
			ChartsCommand = new RelayCommand(async obj => await NavigateAsync(typeof(View.Charts)));
			InitializeCurrentView();
		}
		private void InitializeCurrentView()
		{
			CurrentView = _userControlCache.ContainsKey(typeof(View.Filters)) ? _userControlCache[typeof(View.Filters)] : new FiltersVM();
			CurrentView =  _userControlCache.ContainsKey(typeof(View.Filters)) ? _userControlCache[typeof(View.Filters)] : new FiltersVM();
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



