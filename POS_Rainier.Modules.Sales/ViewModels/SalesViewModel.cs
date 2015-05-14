using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using POS_Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Rainier.Modules.Sales.ViewModels
{
    public class SalesViewModel
    {
        public string Content { get; private set; }
        public SalesViewModel() 
        {
            this.Content = "It is a SalesViewModel.";
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () =>
            {
                ViewInjectionManager.Default.Navigate(Regions.Main_Navigation, ModuleType.Sales);
            });
        }
    }
}
