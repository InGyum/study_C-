using Caliburn.Micro;
using System.Security.Policy;
using System.Windows;

namespace StartCalibunApp.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get => !string.IsNullOrEmpty(Name);
        }

        public StrongName DisplayName { get; set; }

        //public ShellViewModel()
        //{
        //    DisplayName = "Basic Caliburn App";
        //}
        public void SayHello()
        {
            MessageBox.Show($"Hello {Name}");
        }
    }
}
