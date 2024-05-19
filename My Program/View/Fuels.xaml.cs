using FiltersApplication.Config;
using FiltersApplication.Model;
using FiltersApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;
using System.Xml.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Data.DataFilter;
using Telerik.Windows.Diagrams.Core;

namespace FiltersApplication.View
{
    public partial class Fuels : UserControl
    {
		public ObservableCollection<Fuel> SelectedFuels { get; set; }
		DispatcherTimer timer = new DispatcherTimer();
		public Fuels()
        {
			LocalizationManager.Manager = new CustomLocalizationManager();
			InitializeComponent();
			Loading();
			radComboBox.SelectionChanged += RadComboBox_SelectionChanged;
		}

		private void timer_tick(object sender, EventArgs e)
		{
			timer.Stop();
			fuelsGrid.IsBusy = false;
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

		private void RefreshItemTemplateSelectedCheckBoxClick(object sender,RoutedEventArgs e)
		{
			if ((sender as CheckBox).IsChecked.Value)
			{
				this.radComboBox.ItemTemplate = this.Resources["CheckBoxItemTemplate"] as DataTemplate;
			}
			else
			{
				this.radComboBox.ItemTemplate = this.Resources["NormalItemTemplate"] as DataTemplate;
			}
		}
		private void RadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			SelectedFuels = new ObservableCollection<Fuel>(radComboBox.SelectedItems.Cast<Fuel>());
			GlobalSingletonFilterModel.Instance.SelectedFuels = SelectedFuels;
		}
		private void fuelsGrid_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			var selectedFuel = fuelsGrid.SelectedItem as Fuel;
			if (e.Key == Key.Delete && selectedFuel != null)
			{
				MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить эту строку?",
					"Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
				if (result == MessageBoxResult.No)
				{
					fuelsGrid.CanUserDeleteRows = false;
				}
				else { fuelsGrid.CanUserDeleteRows = true; }


			}
		}
	}
}


