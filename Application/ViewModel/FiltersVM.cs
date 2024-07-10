using FiltersApplication;
using FiltersApplication.Interfaces;
using FiltersApplication.Model;
using FiltersApplication.Utilities;
using FiltersApplication.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;
using Microsoft.OData.UriParser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using FiltersApplication.DbInitializer;
using System.Windows.Threading;
using System.Xml.Linq;
using Telerik.Windows.Documents.Model.Notes;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Telerik.Windows.Persistence.Core;


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

