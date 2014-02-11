using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Domain
{
    public class OrganizationDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int OrganizationID { get; set; }
        [Required(ErrorMessage = "Please enter a organization name")]
        [Display(Name="Organization")]
        public string OrganizationName { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        [Display(Name = "Address 1")]
        public string OrgAddress_1 { get; set; }
        [Display(Name = "Address 2")]
        public string OrgAddress_2 { get; set; }
        [Required(ErrorMessage = "Please enter city")]
        [Display(Name = "City")]
        public string OrgCity { get; set; }
        [Required(ErrorMessage = "Please enter state")]
        [Display(Name = "State")]
        public string OrgState { get; set; }
        [Required(ErrorMessage = "Please enter zip code")]
        [Display(Name = "Zip Code")]
        public string OrgZipCode { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Fax")]
        public string Fax { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Web Page")]
        [Url]
        public string OrgUrl { get; set; }
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        /*
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdateUserID { get; set; }*/
    }
}