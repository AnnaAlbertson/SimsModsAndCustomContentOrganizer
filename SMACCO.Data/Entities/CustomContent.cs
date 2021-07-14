using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Data.Entities
{
    public class CustomContent
    {
        [Key]
        public int CustomContentID { get; set; }

        [Required]
        [Display(Name = "Is this a Buy Mode item?")]
        public bool IsBuyMode { get; set; }

        [Required]
        [Display(Name = "Is this a Create-A-Sim item?")]
        public bool IsCreateASim { get; set; }

        public string Category { get; set; }
        public string Subcategory { get; set; }

        [ForeignKey(nameof(Downloads))]
        public int DownloadID { get; set; }
        public virtual Download Downloads { get; set; }

        // Picture of Content
    }
}
