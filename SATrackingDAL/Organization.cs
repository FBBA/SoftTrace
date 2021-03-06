//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SATrackingDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization
    {
        public Organization()
        {
            this.Applications = new HashSet<Application>();
            this.BusinessUnits = new HashSet<BusinessUnit>();
        }
    
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string Comment { get; set; }
        public string OrgAddress_1 { get; set; }
        public string OrgAddress_2 { get; set; }
        public string OrgCity { get; set; }
        public string OrgState { get; set; }
        public string OrgZipCode { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string OrgUrl { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string UpdateUserID { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
