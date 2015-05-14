using DevExpress.Mvvm.POCO;
using POS_Infrastructure;
using POS_Rainier.Modules.ClockInOut.ViewModels;
using POS_Rainier.Modules.Sales.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Rainier.Infrastructure.Factory
{
    public class ModuleFactory
    {
        public static object CreateModule(ModuleType moduleType)
        {
            switch (moduleType)
            {
                case ModuleType.Sales       : return ViewModelSource.Create(() => new SalesViewModel());
                case ModuleType.ClockInOut  : return ViewModelSource.Create(() => new ClockInOutViewModel());
                default: throw new Exception();
            }
        }
    }
}
