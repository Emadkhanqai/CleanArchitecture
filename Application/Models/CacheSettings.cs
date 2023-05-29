﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CacheSettings
    {
        public int SlidingExpiration{ get; set; }
        public string DestinationUrl { get; set; }
        public string ApplicationName { get; set; }
        public bool BypassCache { get; set; }
    }
}
