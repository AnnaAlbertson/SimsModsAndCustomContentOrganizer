﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Models.PackModels
{
    public class PackCreate
    {
        public string PackName { get; set; }
        public string Description { get; set; }
        public bool IsOwned { get; set; }
        public int GameID { get; set; }
    }
}