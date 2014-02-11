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
    public class AdditionalToolsDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int AdditionalToolID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide additional tool name")]
        [DisplayName("Additional Tool")]
        public string AdditionalToolName { get; set; }
    }
}
