using FiltersApplication.DbInitializer;
using FiltersApplication.Model;
using FiltersApplication.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;


namespace FiltersApplication.ViewModel
{
	class FuelsVM : ViewModelBase
	{
		private readonly ApplicationDbFuelContext data;
		private ObservableCollection<Fuel> _selectedfuels;
		private ICommand _saveCommand;
		public ObservableCollection<Fuel> Fuels { get; set; }
		public ObservableCollection<Fuel> SelectedFuels
		{
			get { return _selectedfuels; }
			set
			{
				_selectedfuels = value;
				GlobalSingletonFilterModel.Instance.SelectedFuels = _selectedfuels;
				OnPropertyChanged(nameof(SelectedFuels));
			}
		}

		public FuelsVM()
		{
			try
			{
				var options = new DbContextOptionsBuilder<ApplicationDbFuelContext>().UseSqlite("Data Source=DataFilters.db").Options;
				data = new ApplicationDbFuelContext(options);
				data.Database.EnsureCreated();
				data.Fuels.Load();
				Fuels = data.Fuels.Local.ToObservableCollection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("При загрузке данных возникла ошибка! Перезагрузите программу или обратитесь к разработчику программы.", 
					"Ошибка загрузки данных", MessageBoxButton.OK, MessageBoxImage.Error);
				MessageBox.Show(ex.Message);
			}
			finally { data.Database.CloseConnection(); }
		}
		
		public ICommand SaveCommand
		{
			get
			{
				if (_saveCommand == null)
				{
					_saveCommand = new RelayCommand(p => SubmitChangesButton_Click(p));
				}
				return _saveCommand;
			}
		}

		public void SubmitChangesButton_Click(object obj)
		{
			try
			{
				this.data.SaveChanges();
			}
			catch
			{
				MessageBox.Show("При записи данных в базу, обнаружены пустые поля. Заполните пустые поля или удалите их.", 
					"Ошибка записи данных", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			finally
			{
				this.data.Database.CloseConnection();
			}
		}
		
	}
}
