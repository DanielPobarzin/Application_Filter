using FiltersApplication.Model;
using FiltersApplication.ViewModel;
using SharpDX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace FiltersApplication.View
{

	public partial class Calculate : UserControl
	{
		private CalculateVM viewModel;
		private DataTemplate dataFourTemplate;
		private DataTemplate dataThreeTemplate;
		private DispatcherTimer _timer = new DispatcherTimer();
		private int counter = 0;

		public Calculate()
		{
			InitializeComponent();
			viewModel = new CalculateVM();
			this.DataContext = viewModel;

			dataFourTemplate = this.Resources["AshCleanForFourFieldFilter"] as DataTemplate;
			dataThreeTemplate = this.Resources["AshCleanForThreeFieldFilter"] as DataTemplate;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			counter++;
			TimerLabel.Text = (counter != 0) ?  counter.ToString() : "".ToString();

			switch (counter)
			{
				case (1): 
					LoadText.Text = "Загрузка".ToString(); 
					break;

				case (30): 
					LoadText.Text = "Обработка".ToString(); 
					GridAshClean.Children.Clear();
					Start_Btn.Command = viewModel.CalculateCommand;
					viewModel.CaclulateButton_Click(sender);
					break;

				case (80): 
					LoadText.Text = "Расчет".ToString(); 
					break;

				case (99):
					StopTimer();
				
					InitializationAreaResults();
					TimerLabel.Text = "✔".ToString(); 
					LoadText.Text = "".ToString();
					break;
			}

			if (TimerLabel.Text == "✔" && BorderSuccess.ActualHeight != BorderSuccess.MaxHeight)
			{

				Start_Btn.IsChecked = false;
				DoubleAnimation animation = new DoubleAnimation();
				animation.Duration = TimeSpan.FromSeconds(1);
				animation.From = BorderSuccess.ActualHeight;
				animation.To = BorderSuccess.MaxHeight;

				Storyboard.SetTarget(animation, BorderSuccess);
				Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Height)"));

				Storyboard storyboard = new Storyboard();
				storyboard.Children.Add(animation);
				storyboard.Begin();
			}
			if (TimerLabel.Text != "✔" && BorderSuccess.ActualHeight != BorderSuccess.MinHeight)
			{
				DoubleAnimation animation = new DoubleAnimation();
				animation.Duration = TimeSpan.FromSeconds(0.3);
				animation.From = BorderSuccess.ActualHeight;
				animation.To = BorderSuccess.MinHeight;

				Storyboard.SetTarget(animation, BorderSuccess);
				Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Height)"));

				Storyboard storyboard = new Storyboard();
				storyboard.Children.Add(animation);
				storyboard.Begin();
			}
		}
		private void InitializationAreaResults()
		{
			var SelectFuels = GlobalSingletonFilterModel.Instance.SelectedFuels;
			var PropertyStation = GlobalSingletonFilterModel.Instance.CurrentParametersStation;
			var PropertyFilter = GlobalSingletonFilterModel.Instance.SelectedFilter;
			for (int i = 0; i < SelectFuels.Count(); i++)
			{
				var contentTemplatePresenter = new ContentPresenter();
				GridAshClean.RowDefinitions.Add(new RowDefinition());
				switch (PropertyFilter.NumberFields)
				{
					case 3:
						contentTemplatePresenter.ContentTemplate = dataThreeTemplate;
						GridAshClean.Children.Add(contentTemplatePresenter);
						Grid.SetRow(contentTemplatePresenter, i);
						contentTemplatePresenter.ApplyTemplate();

						TextBlock fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
						TextBox firstFieldThreeTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
						TextBox secondFieldThreeTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
						TextBox thirdFieldThreeTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);

						fuel.Text = SelectFuels[i].BrandFuel.ToString();
						firstFieldThreeTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[0].ToString("F4").Replace(",", ".");
						secondFieldThreeTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[1].ToString("F4").Replace(",", ".");
						thirdFieldThreeTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[2].ToString("F4").Replace(",", ".");
						break;

					case 4:
						contentTemplatePresenter.ContentTemplate = dataFourTemplate;
						GridAshClean.Children.Add(contentTemplatePresenter);
						Grid.SetRow(contentTemplatePresenter, i);
						contentTemplatePresenter.ApplyTemplate();

						TextBlock fuelfour = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
						TextBox firstFieldFourTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
						TextBox secondFieldFourTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
						TextBox thirdFieldFourTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);
						TextBox fourFieldFourTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FourField", contentTemplatePresenter);

						fuelfour.Text = SelectFuels[i].BrandFuel.ToString();
						firstFieldFourTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[0].ToString("F4").Replace(",", ".");
						secondFieldFourTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[1].ToString("F4").Replace(",", ".");
						thirdFieldFourTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[2].ToString("F4").Replace(",", ".");
						fourFieldFourTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[3].ToString("F4").Replace(",", ".");
						break;
				}

			}
		}
		private void StartTimer()
		{
			if (counter > 0)
			{
				_timer.Tick -= timer_Tick;
				counter = 0;
			}
			GridLoad.Visibility = Visibility.Visible;
			ImageLoad.Visibility = Visibility.Visible;
			StartCalculate.Visibility = Visibility.Collapsed;
			_timer.Interval = TimeSpan.FromMilliseconds(50);
			_timer.Tick += timer_Tick;
			_timer.Start();
		}

		private void StopTimer()
		{
			if (counter > 0)
			{
				_timer.Tick -= timer_Tick;
				counter = 0;
			}
			GridLoad.Visibility = Visibility.Collapsed;
			ImageLoad.Visibility = Visibility.Collapsed;
			StartCalculate.Visibility = Visibility.Visible;
			_timer.Stop();
			TimerLabel.Text = "".ToString();
		}
		private void Start_Click(object sender, RoutedEventArgs e)
		{
			if (Start_Btn.IsChecked == true)
			{
				if (viewModel.Initialize(sender))
				{
					StartTimer();
					Start_Btn.IsChecked = true;	
				}
				else
				{
					Start_Btn.IsChecked = false;
					StopTimer();
				}
			}
			else
			{
				StopTimer();
			}
		}
	}
}
