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
    
    public partial class DataSource
    {
        public int DataSourceID { get; set; }
        public int ApplicationID { get; set; }
        public int ApplicationEnvironmentID { get; set; }
        public string DataSourceName { get; set; }
        public string SchemaName { get; set; }
        public string DataSourceType { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual ApplicationEnvironment ApplicationEnvironment { get; set; }
    }
}
