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
    public class SkillsRequiredDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int SkillID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide skill")]
        [DisplayName("Skill")]
        public string SkillName { get; set; }
    }
}
