using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.GameModels
{
    public class GameListItem
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public bool IsOwned { get; set; }
        public DateTimeOffset LastPatchUpdate { get; set; }
        public int NumberOfDownloads { get; set; }
    }
}
