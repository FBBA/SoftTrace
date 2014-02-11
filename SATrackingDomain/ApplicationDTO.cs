using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATrackingDomain
{
    public class ApplicationDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int ApplicationID { get; set; }
        public int OrganizationID { get; set; }
        [Required(ErrorMessage = "Please enter application name")]
        [Display(Name = "Application")]
        public string ApplicationName { get; set; }
        [Required(ErrorMessage = "Please enter environment")]
        [Display(Name = "Environment")]
        public string ApplicationEnvironment { get; set; }
        [Required(ErrorMessage = "Please enter developing company")]
        [Display(Name = "Developing Company")]
        public string DevelopingCompany { get; set; }
        [Required(ErrorMessage = "Please enter project manager")]
        [Display(Name = "Project Manager")]
        public string ProjectManager { get; set; }
        [Display(Name = "Operating System")]
        public string OperatingSystem { get; set; }
        [Required(ErrorMessage = "Please enter IDE")]
        [Display(Name = "IDE")]
        public string IDE { get; set; }
        [Required(ErrorMessage = "Please enter version control system")]
        [Display(Name = "Version Control Tool")]
        public string VersionControlTool { get; set; }
        [Display(Name = "VC Server")]
        public string VersionControlPath { get; set; }
        [Required(ErrorMessage = "Please enter application type")]
        [Display(Name = "Application Type")]
        public string ApplicationType { get; set; }
        [Display(Name = "Unit Test Tool")]
        public string UnitTestTool { get; set; }
        [Display(Name = "Deployment Tool")]
        public string DeployementTool { get; set; }
        [Display(Name = "Date Deployed")]
        public Nullable<System.DateTime> DeployedDate { get; set; }
        [Display(Name = "Developed by Us")]
        public string OutsideApplication { get; set; }
        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}
