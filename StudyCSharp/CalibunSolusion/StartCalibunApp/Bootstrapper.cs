using Caliburn.Micro;
using StartCalibunApp.ViewModels;
using System.Windows;

namespace StartCalibunApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ButtonsViewModel>();   // object -> ViewModel
        }
    }
}
