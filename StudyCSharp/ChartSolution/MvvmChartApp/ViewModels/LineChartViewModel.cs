using Caliburn.Micro;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmChartApp.ViewModels
{
    
    public class LineChartViewModel : Conductor<object>
    {
        public ChartValues<double> LineValues { get; set; }
        public LineChartViewModel()
        {

            InitializeChartData();
        }

        private void InitializeChartData()
        {
            LineValues = new ChartValues<double> { 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 12.12 };
        }

    }
    
}
