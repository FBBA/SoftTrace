using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATrackingDAL;
using SATrackingSL;
using System.Web.Mvc;
using System.Data.Entity;
using AutoMapper;

namespace SATrakingBL
{
    public class OrganizationBL : IOrganization
    {
        Entities ctx;

        public OrganizationBL() {
            ctx = new Entities();
        }

        public Organization getOrganization(int orgID) {
            using (ctx) {
                return ctx.Set<Organization>().Find(orgID);
            }
        }

        public List<Organization> getOrgList()
        {
            using (ctx) {
                return ctx.Set<Organization>().ToList();
            }
        }


        public void saveOrganization(Organization org) {
            using (ctx) {
                org.DateCreated = DateTime.Now;
                ctx.Set<Organization>().Add(org);
                ctx.SaveChanges();
            }
        }

        public void updateOrganization(Organization org) {
            using (ctx) {
                Organization locOrg = ctx.Set<Organization>().Find(org.OrganizationID);
                Mapper.CreateMap<Organization, Organization>().ForMember("OrganizationID", r => r.Ignore()).ForMember("DateCreated",r=>r.Ignore());
                locOrg = Mapper.Map(org, locOrg);
                locOrg.DateUpdated = DateTime.Now;
                ctx.SaveChanges();
            }
        }

    }
}
