using SATrackingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Models
{
    public class ApplicationModel
    {
        public ApplicationDTO dtoApp { get; set; }
        public SelectList orgList { get; set; }
    }
}