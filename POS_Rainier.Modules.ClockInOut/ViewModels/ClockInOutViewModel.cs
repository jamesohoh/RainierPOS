using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using POS_Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Rainier.Modules.ClockInOut.ViewModels
{
    public class ClockInOutViewModel
    {
        public string Content { get; private set; }
        public ClockInOutViewModel()
        {
            Content = "It is a ClockInOutViewModel.";
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () =>
            {
                ViewInjectionManager.Default.Navigate(Regions.Main_Content, ModuleType.ClockInOut);
            });
        }
    }
}
