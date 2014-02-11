using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATrackingDAL;
using System.Web.Mvc;

namespace SATrackingSL
{
    public interface IOrganization
    {
        Organization getOrganization(int OrgID);
        List<Organization> getOrgList();
        void saveOrganization(Organization org);
        void updateOrganization(Organization org);
    }
}
