using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopExplorer.Lib.Models
{
    public class AppVersionInfo
    {
        public string Version { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateDateText { get => UpdateDate.ToString("yyyy/MM/dd"); }

        public AppVersionInfo(string version, DateTime updateDate)
        {
            Version = version;
            UpdateDate = updateDate;
        }

        public AppVersionInfo()
        {
            Version = "";
            UpdateDate = new DateTime(2023, 01, 01);
        }
    }
}
