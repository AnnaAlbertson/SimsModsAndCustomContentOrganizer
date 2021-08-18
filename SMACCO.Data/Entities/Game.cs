using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Data.Entities
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }
        
        [Required]
        [Display(Name ="Game Name")]
        public string GameName { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

        [Required]
        [Display(Name = "Is Owned?")]
        public bool IsOwned { get; set; }
        
        [Display(Name = "Last Patch Update")]
        public DateTimeOffset LastPatchUpdate { get; set; }
        ICollection<Pack> ListOfPacks { get; set; }
        ICollection<Download> ListOfDownloads { get; set; }
    }
}
