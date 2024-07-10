using FiltersApplication.Model;
using FiltersApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;
using Telerik.Windows.Controls;

namespace FiltersApplication.View
{
    public partial class Stations : UserControl
    {
		private Station _currentParametersStantion;
		public Stations()
		{
			InitializeComponent();
			comboBoxSmokePumps.Items.AddRange(new object[] { 1, 2, 3});
			comboBoxNumberGrids.Items.AddRange(new object[] { 1, 2});
			comboBoxTypeSlagRemoval.Items.AddRange(new object[] { "Твердое шлакоудаление", "Жидкое шлакоудаление" });
			comboBoxTypeFlueGasSupply.Items.AddRange(new object[] { "Подвод дымовых газов снизу", "Прямой подвод дымовых газов" });
			_currentParametersStantion ??= new Station();
		}
		private void SchemeOne(object sender, RoutedEventArgs e)
		{
			_currentParametersStantion.SchemeBunkerPartitions = 1;
		}
		private void SchemeTwo(object sender, RoutedEventArgs e)
		{
			_currentParametersStantion.SchemeBunkerPartitions = 2;
		}
		private void SchemeThree(object sender, RoutedEventArgs e)
		{
			_currentParametersStantion.SchemeBunkerPartitions = 3;
		}
		private void SchemeFour(object sender, RoutedEventArgs e)
		{
			_currentParametersStantion.SchemeBunkerPartitions = 4;
		}
		private void Size_Click_Min(object sender, RoutedEventArgs e)
		{
			MenuOpen.Visibility = Visibility.Visible;
			MenuClose.Visibility = Visibility.Collapsed;
			DoubleAnimation animation = new DoubleAnimation();
			animation.Duration = TimeSpan.FromSeconds(1);
			animation.From = FormBorder.ActualHeight;
			animation.To = FormBorder.MinHeight;

			Storyboard.SetTarget(animation, FormBorder);
			Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Height)"));

			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			storyboard.Begin();
		}
		private void Size_Click_Max(object sender, RoutedEventArgs e)
		{
			MenuOpen.Visibility = Visibility.Collapsed;
			MenuClose.Visibility = Visibility.Visible;
			DoubleAnimation animation = new DoubleAnimation();
			animation.Duration = TimeSpan.FromSeconds(1);
			animation.From = FormBorder.ActualHeight;
			animation.To = FormBorder.MaxHeight;
		
			Storyboard.SetTarget(animation, FormBorder);
			Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Height)"));

			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			storyboard.Begin();
		}

		private void SavePropertyStation(object sender, RoutedEventArgs e)
		{
			_currentParametersStantion.Mill = Mill.Text;
			ExhaustGasTemperature.Text = ExhaustGasTemperature.Text.Replace(".", ",");
			HeightLiftShift.Text = HeightLiftShift.Text.Replace(".", ",");
			FuelConsumption.Text = FuelConsumption.Text.Replace(".", ",");
			AirSuction.Text = AirSuction.Text.Replace(".", ",");

			if (comboBoxTypeSlagRemoval.SelectedItem != null) { _currentParametersStantion.SlagRemoval = comboBoxTypeSlagRemoval.SelectedItem.ToString(); }
			else { MessageBox.Show("Не указан тип шлакоудаления.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (comboBoxTypeFlueGasSupply.SelectedItem != null) { _currentParametersStantion.TypeFlueGasSupply = comboBoxTypeFlueGasSupply.SelectedItem.ToString(); }
			else { MessageBox.Show("Не указан тип подвода газа к электрофильтру.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (double.TryParse(ExhaustGasTemperature.Text, out double exhaustGasTemperature)) { _currentParametersStantion.ExhaustGasTemperature = exhaustGasTemperature; }
			else { MessageBox.Show("Проверьте правильность ввода значения температуры уходящих газов.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (double.TryParse(FuelConsumption.Text, out double fuelConsumption)) { _currentParametersStantion.FuelConsumption = fuelConsumption; }
			else { MessageBox.Show("Проверьте правильность ввода значения расхода топлива.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
			
			if (comboBoxSmokePumps.SelectedItem != null) { _currentParametersStantion.NumberSmokePumps = Convert.ToInt32(comboBoxSmokePumps.SelectedItem); }
			else { MessageBox.Show("Не указано количество дымососов.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (double.TryParse(AirSuction.Text, out double airSuction)) {_currentParametersStantion.AirSuction = airSuction; }
			else { MessageBox.Show("Проверьте правильность ввода значения присосов воздуха.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (double.TryParse(HeightLiftShift.Text, out double heightLiftShift)) {_currentParametersStantion.HeightLiftShaft = heightLiftShift; }
			else { MessageBox.Show("Проверьте правильность ввода значения высоты подъемной шахты.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (comboBoxNumberGrids.SelectedItem != null)
				_currentParametersStantion.NumberGrids = Convert.ToInt32(comboBoxNumberGrids.SelectedItem);
			else { MessageBox.Show("Не указано количество сеток.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return; }

			if (_currentParametersStantion.SchemeBunkerPartitions == 0) { MessageBox.Show("Выберите схему бункерной перегородки.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Warning); return;}

			try { GlobalSingletonFilterModel.Instance.CurrentParametersStation = _currentParametersStantion; }
			catch { MessageBox.Show("Данные не могут быть записаны. Проверьте правильность ввода.", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Error); }

		}
	}

}
