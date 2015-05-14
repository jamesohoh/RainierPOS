using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using POS_Infrastructure;
using POS_Navigation.ViewModels;
using POS_Navigation.Views;
using POS_Rainier.Infrastructure.Arrangement;
using POS_Rainier.Infrastructure.Factory;
using POS_Rainier.Modules.ClockInOut.ViewModels;
using POS_Rainier.Modules.ClockInOut.Views;
using POS_Rainier.Modules.Sales.ViewModels;
using POS_Rainier.Modules.Sales.Views;
using POS_SignIn.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace POS_Rainier
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() { }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.InitPOS();
            this.SignIn();
        }

        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
        }

        private void InitPOS()
        {
            DXSplashScreen.Show<SplashScreenView>();

            IArrangable configArrangement = ArrangementFactory.CreateArrangement(ArrangeType.Configuration);
            configArrangement.Load();
            configArrangement.Update();
            
            ViewInjectionManager.Default.Inject(
                Regions.Main_Navigation,
                ModuleType.Sales,
                () => NavigationFactory.CreateNavigationItem
                    (ModuleType.Sales, ModuleType.Sales.ToString(),
                    new BitmapImage(new Uri(@"pack://application:,,,/POS_Navigation;component/Resources/Images/Sales.png", UriKind.RelativeOrAbsolute))),
                    typeof(NavigationItemView)
            );

            ViewInjectionManager.Default.Inject(
                Regions.Main_Navigation,
                ModuleType.ClockInOut,
                () => NavigationFactory.CreateNavigationItem
                    (ModuleType.ClockInOut, ModuleType.ClockInOut.ToString(),
                    new BitmapImage(new Uri(@"pack://application:,,,/POS_Navigation;component/Resources/Images/ClockInOut.png", UriKind.RelativeOrAbsolute))),
                    typeof(NavigationItemView)
            );
            
            ViewInjectionManager.Default.Inject(Regions.Main_Content, ModuleType.Sales, () => ModuleFactory.CreateModule(ModuleType.Sales), typeof(SalesView));
            ViewInjectionManager.Default.Inject(Regions.Main_Content, ModuleType.ClockInOut, () => ModuleFactory.CreateModule(ModuleType.ClockInOut), typeof(ClockInOutView));

            ViewInjectionManager.Default.Navigate(Regions.Main_Navigation, ModuleType.Sales);
            ViewInjectionManager.Default.Navigate(Regions.Main_Content, ModuleType.Sales);

            DXSplashScreen.Close();
        }

        private void SignIn()
        {
            DXSplashScreen.Show<SignInView>();
            Thread.Sleep(1500);
            DXSplashScreen.Close();
        }
    }
}
