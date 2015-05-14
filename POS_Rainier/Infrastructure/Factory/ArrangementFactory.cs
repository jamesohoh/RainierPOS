using POS_Rainier.Infrastructure.Arrangement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Rainier.Infrastructure.Factory
{
    public enum ArrangeType
    { 
        Configuration
    }
    public class ArrangementFactory
    {
        public static IArrangable CreateArrangement(ArrangeType arrangeType)
        {
            switch (arrangeType)
            {
                case ArrangeType.Configuration: return new ConfigurationLoader();
                default: throw new Exception();
            }
        }
    }
}
