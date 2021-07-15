using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Data.Entities
{
    public class Mod
    {
        [ForeignKey(nameof(Download))]
        public int ModID { get; set; }
        public virtual Download Download { get; set; }

        [MaxLength(50, ErrorMessage = "You have reached the max number of characters.")]
        public string Category { get; set; }

        [MaxLength(1000, ErrorMessage = "You have reached the max number of characters.")]
        public string Description { get; set; }
    }
}
