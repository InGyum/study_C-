using Caliburn.Micro;
using System;
using System.Threading;

namespace MvvmChartApp.ViewModels
{
    internal class GaugeChartViewModel : Conductor<object>
    {
        double angValue;
        public double AngValue
        {
            get => angValue;
            set
            {
                angValue = value;
                NotifyOfPropertyChange(() => angValue);
            }
        }

        public Timer CustomTimer { get; set; }
        public GaugeChartViewModel()
        {
            CustomTimer = new Timer(TickCallBack);
            CustomTimer.Change(1000, 1000);
        }

        private void TickCallBack(object state)
        {
            AngValue = new Random().Next(20, 300);
        }
    }
}