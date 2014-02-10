using SATracking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Models
{
    public class OrganizationModel
    {
        public OrganizationDTO dtoOrg { get; set; }
        public SelectList stateList { get; set; }
    }
}