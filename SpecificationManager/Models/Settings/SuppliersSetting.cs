using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationManager.Models.Settings
{
    public class SuppliersSetting
    {
        public static Dictionary<string, string> Naming = new Dictionary<string, string>
        {
                {"SP1", "Viyar"}, // SP1
                {"SP2", "MT"}, // SP2
                {"SP3", "Вибор"}, // SP3
                {"SP4", "Hafele"}, // SP4
                {"SP5", "ADS"}, // SP5
                {"SP6", "VDM"}, // SP6
                {"SP7", "KRONAS"}, // SP7
                {"SP8", "OTHER"} // SP8
        };
    }
}
