using FiltersApplication.Model;
using FiltersApplication.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Telerik.Windows.Core;

namespace FiltersApplication.View
{

	public partial class Calculate : UserControl
	{
		private CalculateVM viewModel;
		private DataTemplate dataFourTemplate;
		private DataTemplate dataThreeTemplate;
		private DataTemplate dataDegreeAshTemplate;

		private DispatcherTimer _timer = new DispatcherTimer();
		private int counter = 0;

		public Calculate()
		{
			InitializeComponent();
			viewModel = new CalculateVM();
			this.DataContext = viewModel;

			dataFourTemplate = this.Resources["AshCleanForFourFieldFilter"] as DataTemplate;
			dataThreeTemplate = this.Resources["AshCleanForThreeFieldFilter"] as DataTemplate;
			dataDegreeAshTemplate = this.Resources["DegreeAshCapture"] as DataTemplate;
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
					Start_Btn.Command = viewModel.CalculateCommand;
					break;
				case (50):
					GridAshClean.Children.Clear();
					DegreeAshCapture.Children.Clear();
					GridOptimalShakeMode.Children.Clear();
					break;

				case (80): 
					LoadText.Text = "Расчет".ToString();
					viewModel.CaclulateButton_Click(sender);
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
		#region UIElements 
		Border ExternalBorder;
		Border InternalBorder;
		TextBlock fuel;
		TextBox firstFieldTextBox;
		TextBox secondFieldTextBox;
		TextBox thirdFieldTextBox;
		TextBox fourFieldTextBox;

		#endregion

		private async void InitializationAreaResults()
		{
			var SelectFuels = GlobalSingletonFilterModel.Instance.SelectedFuels;
			var PropertyStation = GlobalSingletonFilterModel.Instance.CurrentParametersStation;
			var PropertyFilter = GlobalSingletonFilterModel.Instance.SelectedFilter;
			for (int i = 0; i < SelectFuels.Count(); i++)
			{
				var contentTemplatePresenter = new ContentPresenter();
				var contentTemplateShakeModPresenter = new ContentPresenter();
				var contentTemplateAshCapturePresenter = new ContentPresenter();

				GridAshClean.RowDefinitions.Add(new RowDefinition());
				GridOptimalShakeMode.RowDefinitions.Add(new RowDefinition());
				DegreeAshCapture.RowDefinitions.Add(new RowDefinition());

				switch (PropertyFilter.NumberFields)
				{
					case 3:
						await ContentAshCleanForThreeFields(contentTemplatePresenter, SelectFuels, i);
						await ContentShakeModeForThreeFields(contentTemplateShakeModPresenter, SelectFuels, i);
						break;

					case 4:
						await ContentAshCleanForFourFields(contentTemplatePresenter, SelectFuels, i);
						await ContentShakeModeForFourFields(contentTemplateShakeModPresenter, SelectFuels, i);
						break;
				}
				await ContentDegreeAshCapture(contentTemplateAshCapturePresenter, SelectFuels, i);
			}
		}
		private async Task ContentDegreeAshCapture(ContentPresenter contentTemplatePresenter, ObservableCollection<Fuel> SelectFuels, int i)
		{
			contentTemplatePresenter.ContentTemplate = dataDegreeAshTemplate;

			DegreeAshCapture.Children.Add(contentTemplatePresenter);
			Grid.SetRow(contentTemplatePresenter, i);
			contentTemplatePresenter.ApplyTemplate();

			ExternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("ExternalBorder", contentTemplatePresenter);
			InternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("InternalBorder", contentTemplatePresenter);
			fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
			firstFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);

			if (InternalBorder.Background is LinearGradientBrush linearGradientBrush)
			{
				var borderBrush = ExternalBorder.BorderBrush as SolidColorBrush;
				LinearGradientBrush newLinearGradientBrush = new LinearGradientBrush();
				newLinearGradientBrush.GradientStops.Add(new GradientStop(borderBrush.Color, 0));
				newLinearGradientBrush.GradientStops.Add(new GradientStop(linearGradientBrush.GradientStops[1].Color, 1));
				InternalBorder.Background = newLinearGradientBrush;
			}

			fuel.Text = SelectFuels[i].BrandFuel.ToString();
			var result = Convert.ToDouble(viewModel.Results[SelectFuels[i].BrandFuel].DegreeAshCapture) * 100;
			firstFieldTextBox.Text = result.ToString("F4").Replace(",", ".");
			await Task.CompletedTask;
		}
		private async Task ContentAshCleanForThreeFields(ContentPresenter contentTemplatePresenter, ObservableCollection<Fuel> SelectFuels, int i)
		{
			contentTemplatePresenter.ContentTemplate = dataThreeTemplate;

			GridAshClean.Children.Add(contentTemplatePresenter);
			Grid.SetRow(contentTemplatePresenter, i);
			contentTemplatePresenter.ApplyTemplate();

			ExternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("ExternalBorder", contentTemplatePresenter);
			InternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("InternalBorder", contentTemplatePresenter);
			fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
			firstFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
			secondFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
			thirdFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);

			if (InternalBorder.Background is LinearGradientBrush linearGradientBrush)
			{
				var borderBrush = ExternalBorder.BorderBrush as SolidColorBrush;
				LinearGradientBrush newLinearGradientBrush = new LinearGradientBrush();
				newLinearGradientBrush.GradientStops.Add(new GradientStop(borderBrush.Color, 0));
				newLinearGradientBrush.GradientStops.Add(new GradientStop(linearGradientBrush.GradientStops[1].Color, 1));
				InternalBorder.Background = newLinearGradientBrush;
			}

			fuel.Text = SelectFuels[i].BrandFuel.ToString();
			firstFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[0].ToString("F4").Replace(",", ".");
			secondFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[1].ToString("F4").Replace(",", ".");
			thirdFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[2].ToString("F4").Replace(",", ".");
			await Task.CompletedTask;
		}
		private async Task ContentAshCleanForFourFields(ContentPresenter contentTemplatePresenter, ObservableCollection<Fuel> SelectFuels, int i)
		{
			contentTemplatePresenter.ContentTemplate = dataFourTemplate;
			GridAshClean.Children.Add(contentTemplatePresenter);
			Grid.SetRow(contentTemplatePresenter, i);
			contentTemplatePresenter.ApplyTemplate();

			ExternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("ExternalBorder", contentTemplatePresenter);
			InternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("InternalBorder", contentTemplatePresenter);
			fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
			firstFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
			secondFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
			thirdFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);
			fourFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FourField", contentTemplatePresenter);

			if (InternalBorder.Background is LinearGradientBrush llinearGradientBrush)
			{
				var borderBrush = ExternalBorder.BorderBrush as SolidColorBrush;
				LinearGradientBrush newLinearGradientBrush = new LinearGradientBrush();
				newLinearGradientBrush.GradientStops.Add(new GradientStop(borderBrush.Color, 0));
				newLinearGradientBrush.GradientStops.Add(new GradientStop(llinearGradientBrush.GradientStops[1].Color, 1));
				InternalBorder.Background = newLinearGradientBrush;
			}
			fuel.Text = SelectFuels[i].BrandFuel.ToString();
			firstFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[0].ToString("F4").Replace(",", ".");
			secondFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[1].ToString("F4").Replace(",", ".");
			thirdFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[2].ToString("F4").Replace(",", ".");
			fourFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].AshConcentrationEntranceMthField[3].ToString("F4").Replace(",", ".");
			await Task.CompletedTask;
		}
		private async Task ContentShakeModeForFourFields(ContentPresenter contentTemplatePresenter, ObservableCollection<Fuel> SelectFuels, int i)
		{
			contentTemplatePresenter.ContentTemplate = dataFourTemplate;
			GridOptimalShakeMode.Children.Add(contentTemplatePresenter);
			Grid.SetRow(contentTemplatePresenter, i);
			contentTemplatePresenter.ApplyTemplate();

			ExternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("ExternalBorder", contentTemplatePresenter);
			InternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("InternalBorder", contentTemplatePresenter);
			fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
			firstFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
			secondFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
			thirdFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);
			fourFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FourField", contentTemplatePresenter);

			if (InternalBorder.Background is LinearGradientBrush llinearGradientBrush)
			{
				var borderBrush = ExternalBorder.BorderBrush as SolidColorBrush;
				LinearGradientBrush newLinearGradientBrush = new LinearGradientBrush();
				newLinearGradientBrush.GradientStops.Add(new GradientStop(borderBrush.Color, 0));
				newLinearGradientBrush.GradientStops.Add(new GradientStop(llinearGradientBrush.GradientStops[1].Color, 1));
				InternalBorder.Background = newLinearGradientBrush;
			}
			fuel.Text = SelectFuels[i].BrandFuel.ToString();
			firstFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[0].ToString("F4").Replace(",", ".");
			secondFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[1].ToString("F4").Replace(",", ".");
			thirdFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[2].ToString("F4").Replace(",", ".");
			fourFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[3].ToString("F4").Replace(",", ".");
			await Task.CompletedTask;
		}

		private async Task ContentShakeModeForThreeFields(ContentPresenter contentTemplatePresenter, ObservableCollection<Fuel> SelectFuels, int i)
		{
			contentTemplatePresenter.ContentTemplate = dataThreeTemplate;

			GridOptimalShakeMode.Children.Add(contentTemplatePresenter);
			Grid.SetRow(contentTemplatePresenter, i);
			contentTemplatePresenter.ApplyTemplate();

			ExternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("ExternalBorder", contentTemplatePresenter);
			InternalBorder = (Border)contentTemplatePresenter.ContentTemplate.FindName("InternalBorder", contentTemplatePresenter);
			fuel = (TextBlock)contentTemplatePresenter.ContentTemplate.FindName("Fuel", contentTemplatePresenter);
			firstFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("FirstField", contentTemplatePresenter);
			secondFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("SecondField", contentTemplatePresenter);
			thirdFieldTextBox = (TextBox)contentTemplatePresenter.ContentTemplate.FindName("ThirdField", contentTemplatePresenter);

			if (InternalBorder.Background is LinearGradientBrush linearGradientBrush)
			{
				var borderBrush = ExternalBorder.BorderBrush as SolidColorBrush;
				LinearGradientBrush newLinearGradientBrush = new LinearGradientBrush();
				newLinearGradientBrush.GradientStops.Add(new GradientStop(borderBrush.Color, 0));
				newLinearGradientBrush.GradientStops.Add(new GradientStop(linearGradientBrush.GradientStops[1].Color, 1));
				InternalBorder.Background = newLinearGradientBrush;
			}

			fuel.Text = SelectFuels[i].BrandFuel.ToString();
			firstFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[0].ToString("F4").Replace(",", ".");
			secondFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[1].ToString("F4").Replace(",", ".");
			thirdFieldTextBox.Text = viewModel.Results[SelectFuels[i].BrandFuel].OptimalAshShakingMode[2].ToString("F4").Replace(",", ".");
			await Task.CompletedTask;
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
