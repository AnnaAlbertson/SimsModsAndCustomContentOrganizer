using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.ModModels
{
    public class ModDetails
    {
        public int ModID { get; set; }
        public string DownloadName { get; set; }
        public string CreatorName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
