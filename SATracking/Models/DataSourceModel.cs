﻿using SATrackingDAL;
using SATrackingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Models
{
    public class DataSourceModel
    {
        public DataSourceDTO dtoDS {get; set;}
        public SelectList appEnvList { get; set; }
    }
}