using FiltersApplication.Model;
using FiltersApplication.Utilities;
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

		private void Home(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Home));
		}
		private void Filter(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Filters));
		}
		private void Fuel(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Fuels));
		}
		private void Station(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Stations));

		}
		private void Calculate(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Calculate));
		}
		private void Chart(object obj)
		{
			CurrentView = GetViewModelInstance(typeof(View.Charts));
		}

		public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            FiltersCommand = new RelayCommand(Filter);
            FuelsCommand = new RelayCommand(Fuel);
            StationsCommand = new RelayCommand(Station);
            CalculateCommand = new RelayCommand(Calculate);
            ChartsCommand = new RelayCommand(Chart);

			CurrentView = _userControlCache.ContainsKey(typeof(View.Home)) ? _userControlCache[typeof(View.Home)] : new HomeVM();
		}
		private UserControl GetViewModelInstance(Type viewType)
		{
			if (!_userControlCache.ContainsKey(viewType))
			{
				UserControl view = (UserControl)Activator.CreateInstance(viewType);
				_userControlCache[viewType] = view;
			}
			return _userControlCache[viewType];
		}
	}
}
