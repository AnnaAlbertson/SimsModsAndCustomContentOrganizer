using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.DownloadModels
{
    public class DownloadDetails
    {
        public int DownloadID { get; set; }
        public string DownloadName { get; set; }
        public string CreatorName { get; set; }
        public string DownloadURL { get; set; }
        public DateTime LastDownloaded { get; set; }
        public bool IsMod { get; set; }
        public bool IsCustomContent { get; set; }
        public string GameName { get; set; }

        //public List<PackModels.PackListItem> ListOfPacks { get; set; }
        //public List<ModModels.ModListItem> ListOfMods { get; set; }
        //public List<CustomContentModels.CustomContentListItem> ListOfCustomContent { get; set; }
    }
}
