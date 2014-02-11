using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class DeploymentServerBL : IItemComlexSL<DeploymentServer, vwAllDeploymentServer, vwDeploymentServer>
    {
        Entities ctx;

        public DeploymentServerBL(Entities newCtx)
        {
            ctx = newCtx;
        }

        public List<vwDeploymentServer> getItemList(int appID)
        {
            using (ctx) {
                return ctx.Set<vwDeploymentServer>().Where(ds => ds.ApplicationID == appID).ToList();
            }
        }

        public DeploymentServer getItem(int dtsID)
        {
            using (ctx) {
                return ctx.Set<DeploymentServer>().Find(dtsID);
            }
        }

        public void addItem(DeploymentServer dtSrs)
        {
            using (ctx) {
                ctx.Set<DeploymentServer>().Add(dtSrs);
                ctx.SaveChanges();
            }
        }

        public void updateItem(DeploymentServer dtSrs)
        {
            using (ctx) {
                DeploymentServer locSvr = ctx.Set<DeploymentServer>().Find(dtSrs.DeploymentServerID);
                locSvr.ApplicationEnvironmentID = dtSrs.ApplicationEnvironmentID;
                locSvr.DeploymentServerName = dtSrs.DeploymentServerName;
                ctx.SaveChanges();
            }
        }

        public List<vwAllDeploymentServer> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllDeploymentServer>().ToList();
            }
        }
    }
}
