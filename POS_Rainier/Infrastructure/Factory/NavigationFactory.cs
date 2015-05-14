using DevExpress.Mvvm.POCO;
using POS_Infrastructure;
using POS_Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace POS_Rainier.Infrastructure.Factory
{
    public class NavigationFactory
    {
        public static object CreateNavigationItem(ModuleType moduleType, string strTitle, BitmapImage bmpImage)
        {
            var navItemViewModel = ViewModelSource.Create(() => new NavigationItemViewModel());
            navItemViewModel.Title = strTitle;
            navItemViewModel.Image = bmpImage;
            navItemViewModel.ModuleType = moduleType;
            return navItemViewModel;
        }
    }
}
