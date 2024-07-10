using FiltersApplication.Model;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FiltersApplication.View
{

	public partial class Calculate : UserControl
	{
		private DataTemplate dataThreeTemplate;
		private DataTemplate dataFourTemplate;


		public Calculate()
		{
			InitializeComponent();
			DataContext = new CalculateVM();

		}
		DispatcherTimer _timer = new DispatcherTimer();
		int counter = 0;

		private void timer_Tick(object sender, EventArgs e)
		{
			counter++;
			if (counter == 0) { TimerLabel.Text = "".ToString(); }
			else { TimerLabel.Text = counter.ToString(); }

			switch (counter)
			{
				case (1): LoadText.Text = "Загрузка".ToString(); break;
				case (30): LoadText.Text = "Обработка".ToString(); break;
				case (80): LoadText.Text = "Расчет".ToString(); break;
				case (99): _timer.Stop(); TimerLabel.Text = "✔".ToString(); LoadText.Text = "".ToString(); break;
			}
			if (TimerLabel.Text == "✔")
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
			else
			{
				DoubleAnimation animation = new DoubleAnimation();
				animation.Duration = TimeSpan.FromSeconds(0.1);
				animation.From = BorderSuccess.ActualHeight;
				animation.To = BorderSuccess.MinHeight;

				Storyboard.SetTarget(animation, BorderSuccess);
				Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Height)"));

				Storyboard storyboard = new Storyboard();
				storyboard.Children.Add(animation);
				storyboard.Begin();
			}
		}
		private void StartTimer()
		{
			if (counter > 0)
			{
				_timer.Tick -= timer_Tick;
				counter = 0;
			}
			if (DataContext is CalculateVM vm && vm.Execute)
			{
				GridLoad.Visibility = Visibility.Visible;
				ImageLoad.Visibility = Visibility.Visible;
				StartCalculate.Visibility = Visibility.Collapsed;
			}
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
		private void Start_Btn_Checked(object sender, RoutedEventArgs e)
		{
			StartTimer();

		}

		private void Start_Btn_Unchecked(object sender, RoutedEventArgs e)
		{
			StopTimer();
		}

		private void Uncheck_Stop(object sender, RoutedEventArgs e)
		{
			Start_Btn.IsChecked = false;
		}
		private void Start_Click(object sender, RoutedEventArgs e)
		{
			if (Start_Btn.IsChecked == true)
			{
				if (DataContext is CalculateVM vm)
				{
					Start_Btn.Command = vm.CalculateCommand;
					if (vm.Execute)
					{
						Start_Btn.IsChecked = true;
						Start_Btn_Checked(sender, e);
					}
					else
					{
						Start_Btn.IsChecked = false;
						Start_Btn_Unchecked(sender, e);
					}
				}
			}
		}
		//private void CaclulateProc(CalculatingProcess result, EventArgs e)
		//{
		//	if (DataContext is CalculateVM vm) 
		//	{
		//		if (vm.Execute)
		//		{
		//			switch (vm.SelectFilter.NumberFields)
		//			{
		//				case 3:
		//					{
		//						dataThreeTemplate = (DataTemplate)Application.Current.FindResource("AshCleanForThreeFieldFilter");
		//						Grid threegrid = (Grid)dataThreeTemplate.LoadContent();
		//						TextBox firstFieldTextBox = (TextBox)threegrid.FindName("FirstField");
		//						TextBox secondFieldTextBox = (TextBox)threegrid.FindName("SecondField");
		//						TextBox thirdFieldTextBox = (TextBox)threegrid.FindName("ThirdField");
		//						firstFieldTextBox.Text = result.AshConcentrationEntranceMthField[0].ToString();
		//						secondFieldTextBox.Text = result.AshConcentrationEntranceMthField[1].ToString();
		//						thirdFieldTextBox.Text = result.AshConcentrationEntranceMthField[2].ToString();
		//						break;
		//					}
		//					case 4:
		//					{
		//						dataFourTemplate = (DataTemplate)Application.Current.FindResource("AshCleanForFourFieldFilter");
		//						Grid fourgrid = (Grid)dataFourTemplate.LoadContent();
		//						TextBox fourfirstFieldTextBox = (TextBox)fourgrid.FindName("FirstField");
		//						TextBox foursecondFieldTextBox = (TextBox)fourgrid.FindName("SecondField");
		//						TextBox fourthirdFieldTextBox = (TextBox)fourgrid.FindName("ThirdField");
		//						TextBox fourfourFieldTextBox = (TextBox)fourgrid.FindName("FourField");
		//						fourfirstFieldTextBox.Text = result.AshConcentrationEntranceMthField[0].ToString();
		//						foursecondFieldTextBox.Text = result.AshConcentrationEntranceMthField[1].ToString();
		//						fourthirdFieldTextBox.Text = result.AshConcentrationEntranceMthField[2].ToString();
		//						fourfourFieldTextBox.Text = result.AshConcentrationEntranceMthField[3].ToString();
		//						break;
		//					}

		//				default:
		//					break;
		//			}
		//		}
		//	}
		//}
	}
}
