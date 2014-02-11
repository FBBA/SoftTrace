using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SATrackingDomain
{
    public class DataSourceDTO
    {
        [HiddenInput(DisplayValue = false)]
        public int DataSourceID { get; set; }
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Please provide application environment")]
        public int ApplicationEnvironmentID { get; set; }
        [Required(ErrorMessage = "Please provide data source name")]
        public string DataSourceName { get; set; }
        public string SchemaName { get; set; }
        public string DataSourceType { get; set; }
    }
}
