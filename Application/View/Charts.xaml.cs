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
using Telerik.Windows.Controls.Charting;
using Telerik.Windows.Controls.ChartView;
using Telerik.Windows.Controls;
using FiltersApplication.Model;

namespace FiltersApplication.View
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Charts : UserControl
    {
        public Charts()
        {
            InitializeComponent();
        }
		private void ChartTrackBallBehavior_TrackInfoUpdated(object sender, TrackBallInfoEventArgs e)
		{
			DataPointInfo closestDataPoint = e.Context.ClosestDataPoint;
			if (closestDataPoint != null)
			{
				FinancialData data = closestDataPoint.DataPoint.DataItem as FinancialData;
				this.date.Text = data.Date.ToString("MMM dd, yyyy");
				this.price.Text = data.Close.ToString("0,0.00");
			}
		}

	}
}