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
    
    public partial class AdditionalTool
    {
        public int AdditionalToolID { get; set; }
        public int ApplicationID { get; set; }
        public string AdditionalToolName { get; set; }
    
        public virtual Application Application { get; set; }
    }
}