﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace RAT.Domain.Models
{
    public class AssetTransaction : DomainObject
    {

        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        
        //public Asset Asset { get; set; }
        public int Shares { get; set; }
        public Stock Stock { get; set; }
        public DateTime DateJoined { get; set; }

    }
}