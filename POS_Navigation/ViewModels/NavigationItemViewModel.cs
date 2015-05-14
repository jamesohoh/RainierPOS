using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using POS_Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace POS_Navigation.ViewModels
{
    public class NavigationItemViewModel
    {
        public virtual string Title { get; set; }
        public virtual BitmapImage Image { get; set; }
        public virtual ModuleType ModuleType { get; set; }

        public NavigationItemViewModel()
        {
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () =>
            {
                ViewInjectionManager.Default.Navigate(Regions.Main_Content, ModuleType);
            });
        }
    }
}
