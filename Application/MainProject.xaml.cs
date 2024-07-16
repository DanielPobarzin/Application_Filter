using FiltersApplication.Model;
using FiltersApplication.View;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Timers;
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
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace FiltersApplication
{

	public partial class MainProject : Window
	{
		private Random random = new Random();
		DispatcherTimer timer = new DispatcherTimer();
		public MainProject()
        {
            InitializeComponent();
			loading.Source = new Uri(Environment.CurrentDirectory + @"\0001.gif");
            Loading();
		}

        private void MovingWin(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            loading.Position = new TimeSpan(0, 0, 1);
            loading.Play();

        }
        private void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            loading.Visibility = Visibility.Hidden;
            BasGrid.Visibility = Visibility.Visible;
			Bord.Background = new SolidColorBrush(Color.FromRgb(33, 37, 41));
		}
        void Loading()
        {
			timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 7);
			timer.Start();
		}

		private void Size_Click_Min(object sender, EventArgs e)
		{
			MenuOpen.Visibility = Visibility.Visible;
			MenuClose.Visibility = Visibility.Collapsed;
			NavigationPanel.Visibility = Visibility.Collapsed;
			Autograpf.Visibility = Visibility.Collapsed;
			DoubleAnimation animation = new DoubleAnimation();
			animation.Duration = TimeSpan.FromSeconds(0.5);
			animation.From = NavigationGrid.ActualWidth;
			animation.To = NavigationGrid.MinWidth;

			Storyboard.SetTarget(animation, NavigationGrid);
			Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Width)"));

			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			storyboard.Begin();
		}
		private void Size_Click_Max(object sender, EventArgs e)
		{
			MenuOpen.Visibility = Visibility.Collapsed;
			MenuClose.Visibility = Visibility.Visible;
			NavigationPanel.Visibility= Visibility.Visible;
			Autograpf.Visibility=Visibility.Visible;
			DoubleAnimation animation = new DoubleAnimation();
			animation.Duration = TimeSpan.FromSeconds(0.5);
			animation.From = NavigationGrid.ActualWidth;
			animation.To = NavigationGrid.MaxWidth;

			Storyboard.SetTarget(animation, NavigationGrid);
			Storyboard.SetTargetProperty(animation, new PropertyPath("(FrameworkElement.Width)"));

			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			storyboard.Begin();
		}
		private void Window_SizeChanged(object sender, EventArgs e)
		{
			if (ResponsiveWindow.ActualWidth < 500)
			{
				Size_Click_Min(MenuClose, EventArgs.Empty);
			}
			else
			{
				Size_Click_Max(MenuOpen, EventArgs.Empty);			
			}
		}
	}
}
