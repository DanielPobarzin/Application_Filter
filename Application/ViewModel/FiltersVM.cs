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
	class FiltersVM : ViewModelBase
    {

		private readonly ApplicationDbFilterContext db;
		private ICommand _saveCommand;
		public ObservableCollection<Filter> Filters { get; set; }
		private Filter _selectedFilter;
		 public Filter SelectedFilter
		{
			get { return _selectedFilter; }
            set
            {
                _selectedFilter = value;
                GlobalSingletonFilterModel.Instance.SelectedFilter = _selectedFilter;
                OnPropertyChanged(nameof(SelectedFilter));
			}
		}
		public FiltersVM() 
		{
			try
			{
				var options = new DbContextOptionsBuilder<ApplicationDbFilterContext>().UseSqlite("Data Source=DataFilters.db").Options;
				db = new ApplicationDbFilterContext(options);
				db.Database.EnsureCreated();
				db.Filters.Load();
				Filters = db.Filters.Local.ToObservableCollection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("При загрузке данных возникла ошибка! Перезагрузите программу или обратитесь к разработчику программы.",
					"Ошибка загрузки данных", MessageBoxButton.OK, MessageBoxImage.Error);
				MessageBox.Show(ex.Message);
			}
			finally { db.Database.CloseConnection(); }

		}
		public ICommand SaveCommand
        {
            get
			{
				_saveCommand ??= new RelayCommand(execute: p => SubmitChangesButton_Click(p));
                return _saveCommand;
            }
        }
		public void SubmitChangesButton_Click(object obj)
		{
			try
			{
				this.db.SaveChanges();
			}
			catch
			{
				MessageBox.Show("При записи данных в базу, обнаружены пустые поля. Заполните пустые поля или удалите их.",
				"Ошибка записи данных", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			finally
			{
				this.db.Database.CloseConnection();
			}
		}

	}
}

