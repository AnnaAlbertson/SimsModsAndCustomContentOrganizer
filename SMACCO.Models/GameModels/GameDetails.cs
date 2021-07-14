using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.GameModels
{
    public class GameDetails
    {
        public int GameID { get; set; }

        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        [Display(Name = "Do you own this game?")]
        public bool IsOwned { get; set; }

        [Display(Name = "Last Patch Update")]
        public DateTimeOffset LastPatchUpdate { get; set; }

        //public List<PackModels.PackListItem> ListOfPacks { get; set; }
        //public List<DownloadModels.DownloadListItem> ListOfDownloads { get; set; }
    }
}
