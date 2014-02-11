using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SATrackingDomain
{
    public class DeploymentServerDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int DeploymentServerID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide deployment environment")]
        [DisplayName("Application Environmen")]
        public int ApplicationEnvironmentID { get; set; }
        [Required(ErrorMessage = "Please provide deployment server name")]
        [DisplayName("Deployment Server")]
        public string DeploymentServerName { get; set; }
    }
}
