using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.GameModels
{
    public class GameEdit
    {
        public bool IsOwned { get; set; }
        public DateTimeOffset LastPatchUpdate { get; set; }
    }
}
