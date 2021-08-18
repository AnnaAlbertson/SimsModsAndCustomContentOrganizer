using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Data.Entities
{
    public class Pack
    {
        [Key]
        public int PackID { get; set; }
        
        [Required]
        [Display(Name = "Pack Name")]
        public string PackName { get; set; }
        
        [Required]
        public Guid OwnerID { get; set; }

        [MaxLength(10000, ErrorMessage ="You have reached the max number of characters.")]
        public string Description { get; set; }

        [Display(Name = "Is Owned?")]
        public bool IsOwned { get; set; }

        ICollection<Download> ListOfDownloads { get; set; }

        [ForeignKey(nameof (Games))]
        public int GameID { get; set; }
        public virtual Game Games { get; set; }
    }
}
