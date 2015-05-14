using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POS_Rainier.Infrastructure.Arrangement
{
    public class ConfigurationLoader : IArrangable
    {
        public bool Update()
        {
            for (int i = 50; i < 100; i++)
            {
                DXSplashScreen.Progress(i);
                DXSplashScreen.SetState(string.Format("{0} %", i + 1));
                Thread.Sleep(40);
            }

            return true;
        }

        public bool Load()
        {
            for (int i = 0; i < 50; i++)
            {
                DXSplashScreen.Progress(i);
                DXSplashScreen.SetState(string.Format("{0} %", i + 1));
                Thread.Sleep(40);
            }

            return true;
        }
    }
}
