using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace BusinessLogic
{
    class Car :Notifier
    {
        private double Speed;

        public double speed 
        { 
            get => Speed;
            set
            {
                Speed = value;
                OnPropertyChanged("speed");
            }
        }

        private Color color;
        public Color Color 
        {
            get
            {
                return color;
            }
            set 
            {
                color = value;
                OnPropertyChanged("color");
            }
        }
        public Human Driver { get; set; }

    }
    public class Human
    {
        public string Name { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
}
