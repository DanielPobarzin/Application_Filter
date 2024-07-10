using Microsoft.Data.Sqlite;
using FiltersApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using FiltersApplication.Model;
using Microsoft.OData.Edm;
using System.Xml.Linq;
using FiltersApplication.Interfaces;
using System.Windows.Threading;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Telerik.Windows.Controls;
using FiltersApplication.Config;
using System.Collections.ObjectModel;


namespace FiltersApplication.View
{

    public partial class Filters : UserControl
    {
		public Filter SelectedFilter { get; set; }
		public Filters()
		{
			LocalizationManager.Manager = new CustomLocalizationManager();
			InitializeComponent();
			Loading();
		}
		DispatcherTimer timer = new DispatcherTimer();
		private void timer_tick(object sender, EventArgs e)
		{
			timer.Stop();
			filtersGrid.IsBusy = false;
		}
		void Loading()
		{
			timer.Tick += timer_tick;
			timer.Interval = new TimeSpan(0, 0, 4);
			timer.Start();
		}
		private void Example_ThemeChanged(object sender, EventArgs e)
		{
			this.root.Resources.MergedDictionaries.Clear();
			this.root.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/ComboBox;component/MultipleSelection/ComboBoxStyles.xaml", UriKind.RelativeOrAbsolute) });
		}

		private void MultipleSelectionBoxTemplateCheckBoxClick(object sender, RoutedEventArgs e)
		{
			this.radComboBox.MultipleSelectionBoxTemplate = (sender as CheckBox).IsChecked.Value ? this.Resources["MultipleSelectionBoxTemplate"] as DataTemplate : null;
		}

		private void filtersGrid_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			var selectedFilter = filtersGrid.SelectedItem as Filter;
			if (e.Key == Key.Delete && selectedFilter != null)
			{
				MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить эту строку?", 
					"Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
				if (result == MessageBoxResult.No)
				{
					filtersGrid.CanUserDeleteRows = false;
				}
				else { filtersGrid.CanUserDeleteRows = true; }

			}
		}
	}
}