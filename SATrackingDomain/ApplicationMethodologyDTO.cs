using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SATrackingDomain
{
    public class ApplicationMethodologyDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int ApplicationMethodologyID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide methodology")]
        public string ApplicationMethodologyText { get; set; }
    }
}
