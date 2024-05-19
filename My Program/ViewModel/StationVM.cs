using FiltersApplication.DbInitializer;
using FiltersApplication.Model;
using FiltersApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FiltersApplication.ViewModel
{
    class StationVM : ViewModelBase
    {
		private Station _currentParametersStation;

		public Station CurrentParametersStation
		{
			get { return _currentParametersStation; }
			set
			{
				_currentParametersStation = value;
				GlobalSingletonFilterModel.Instance.CurrentParametersStation = _currentParametersStation;
				OnPropertyChanged(nameof(CurrentParametersStation));
			}
		}

		public StationVM()
        {
			try
			{

			}catch 
			{
				
			}
			finally
			{

			}
        }
    }
}
