using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class ApplicationMethodologyBL: IItemSL<ApplicationMethodology, vwAllMethodology>
    {
        Entities ctx;

        public ApplicationMethodologyBL(Entities newCtx) {
            ctx = newCtx;
        }

        public List<ApplicationMethodology> getItemList(int appID)
        {
            using (ctx) {
                return ctx.Set<ApplicationMethodology>().Where(mthd => mthd.ApplicationID == appID).ToList();
            }
        }

        public ApplicationMethodology getItem(int mthdID)
        {
            using (ctx) {
                return ctx.Set<ApplicationMethodology>().Find(mthdID);
            }
        }

        public void addItem(ApplicationMethodology appMthd)
        {
            using (ctx) {
                ctx.Set<ApplicationMethodology>().Add(appMthd);
                ctx.SaveChanges();
            }
        }

        public void updateItem(ApplicationMethodology appMthd)
        {
            using (ctx) {
                ApplicationMethodology locMthd = ctx.Set<ApplicationMethodology>().Find(appMthd.ApplicationMethodologyID);
                locMthd.ApplicationMethodologyText = appMthd.ApplicationMethodologyText;
                ctx.SaveChanges();
            }
        }

        public List<vwAllMethodology> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllMethodology>().ToList();
            }
        }



        public IQueryable<ApplicationMethodology> getItemListCond(params System.Linq.Expressions.Expression<Func<ApplicationMethodology, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
