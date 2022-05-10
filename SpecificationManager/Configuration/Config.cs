using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SpecificationManager.Configuration
{
    public static class Config 
    {
        public static string ReplaceProdListDefaultPath
        { 
            get => ConfigurationManager.AppSettings["replaceProdListDefaultPath"];  
        }

        public static string ReplaceProdListCurrentPath
        {
            get => ConfigurationManager.AppSettings["replaceProdListCurrentPath"];
            set 
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["replaceProdListCurrentPath"].Value = value;
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

    }


}
