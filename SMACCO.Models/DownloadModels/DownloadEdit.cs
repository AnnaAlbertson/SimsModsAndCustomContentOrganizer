using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.DownloadModels
{
    public class DownloadEdit
    {
        public int DownloadID { get; set; }
        public string DownloadName { get; set; }
        public string CreatorName { get; set; }
        public string DownloadURL { get; set; }
        public DateTime LastDownloaded { get; set; }
        public bool IsMod { get; set; }
        public bool IsCustomContent { get; set; }
        public int GameID { get; set; }
    }
}
