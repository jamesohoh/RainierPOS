using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Infrastructure
{
    public enum ModuleType
    {
        Sales,
        ClockInOut,
        Inventory,
        Employee,
        Customers,
        Reports,
        Setting
    }

    public static class Regions
    {
        public static string Main_Content { get { return "MainContentRegion"; } }
        public static string Main_Navigation { get { return "NavigationRegion"; } }
    }
}
