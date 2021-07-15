using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.CustomContent_Models
{
    public class CustomContentEdit
    {
        public bool IsBuyMode { get; set; }
        public bool IsCreateASim { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
    }
}
