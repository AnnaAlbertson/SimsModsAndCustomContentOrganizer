using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Data.Entities
{
    public class Download
    {
        [Key]
        public int DownloadID { get; set; }

        [Required]
        [Display(Name = "Name of Download")]
        public string DownloadName { get; set; }

        [Display(Name = "Name of Creator")]
        public string CreatorName { get; set; }

        [Url]
        [Display(Name = "Link to Download")]
        public string DownloadURL { get; set; }

        [Display(Name = "When was this downloaded?")]
        public DateTime LastDownloaded { get; set; }

        [Required]
        [Display(Name = "Is this a mod?")]
        public bool IsMod { get; set; }

        [Required]
        [Display(Name = "Is this Custom Content?")]
        public bool IsCustomContent { get; set; }

        [ForeignKey(nameof(Games))]
        public int GameID { get; set; }
        public virtual Game Games { get; set; }

        ICollection<Pack> ListOfPacks {get; set;}
        ICollection<Mod> ListOfMods {get; set;}
        ICollection<CustomContent> ListOfCustomContents { get; set; }
    }
}
