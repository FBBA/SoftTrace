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
    public class FrameworkUsedDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int FrameworkID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide framework name")]
        [DisplayName("Framework Name")]
        public string FrameworkName { get; set; }
    }
}
