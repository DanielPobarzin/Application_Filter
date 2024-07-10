using FiltersApplication.Config;
using FiltersApplication.Model;
using FiltersApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace FiltersApplication.View
{
	public partial class Fuels : UserControl
    {
		public ObservableCollection<Fuel> SelFuels { get; set; }
		DispatcherTimer timer = new DispatcherTimer();
		
		public Fuels()
        {
			LocalizationManager.Manager = new CustomLocalizationManager();
			InitializeComponent();
			Loading();
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
            SelFuels = new ObservableCollection<Fuel>(radComboBox.SelectedItems.Cast<Fuel>());
			if (DataContext is FuelsVM viewModel) 
				viewModel.SelectedFuels = SelFuels; 
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


