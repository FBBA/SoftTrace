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
    public class DevelopmentLanguageDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int LanguageID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage="Please provide language name")]
        [DisplayName("Language")]
        public string LanguageName { get; set; }
    }
}
