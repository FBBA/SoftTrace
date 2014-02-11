using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class FrameworkUsedBL : IItemSL<FrameworkUsed, vwAllFramework>
    {
        Entities ctx;

        public FrameworkUsedBL() {
            ctx = new Entities();
        }

        public List<FrameworkUsed> getItemList(int appID)
        {
            using (ctx) {
                return ctx.Set<FrameworkUsed>().Where(fr => fr.ApplicationID == appID).ToList();
            }
        }

        public FrameworkUsed getItem(int frmwID)
        {
            using (ctx) {
                return ctx.Set<FrameworkUsed>().Find(frmwID);
            }
        }

        public void addItem(FrameworkUsed frWork)
        {
            using (ctx) {
                ctx.Set<FrameworkUsed>().Add(frWork);
                ctx.SaveChanges();
            }
        }

        public void updateItem(FrameworkUsed frWork)
        {
            using (ctx) {
                FrameworkUsed locFrm = ctx.Set<FrameworkUsed>().Find(frWork.FrameworkID);
                locFrm.FrameworkName = frWork.FrameworkName;
                ctx.SaveChanges();
            }
        }

        public List<vwAllFramework> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllFramework>().ToList();
            }
        }


        public IQueryable<FrameworkUsed> getItemListCond(params System.Linq.Expressions.Expression<Func<FrameworkUsed, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
