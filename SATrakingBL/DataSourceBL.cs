using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class DataSourceBL : IItemComlexSL<DataSource, vwAllDataSource, vwDataSource>
    {
        Entities ctx;

        public DataSourceBL(Entities newCtx)
        {
            ctx = newCtx;
        }

        public List<vwAllDataSource> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllDataSource>().ToList();
            }
        }

        public List<vwDataSource> getItemList(int appID)
        {
            using (ctx) {
                return ctx.Set<vwDataSource>().Where(dts => dts.ApplicationID == appID).ToList();
            }
        }

        public DataSource getItem(int dtsID)
        {
            using (ctx) {
                return ctx.Set<DataSource>().Find(dtsID);
            }
        }

        public void addItem(DataSource dtSrs)
        {
            using (ctx) {
                ctx.Set<DataSource>().Add(dtSrs);
                ctx.SaveChanges();
            }
        }

        public void updateItem(DataSource dtSrs)
        {
            using (ctx) {
                DataSource locDS = ctx.Set<DataSource>().Find(dtSrs.DataSourceID);
                locDS.DataSourceType = dtSrs.DataSourceType;
                locDS.DataSourceName = dtSrs.DataSourceName;
                locDS.SchemaName = dtSrs.SchemaName;
                ctx.SaveChanges();
            }
        }
    }//end of class
}
