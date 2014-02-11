using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace SATrakingBL
{
    public class AdditionalToolBL: IItemSL<AdditionalTool, vwAllAddTool>
    {
        Entities ctx;

        public AdditionalToolBL() {
            ctx = new Entities();
        }

        public List<AdditionalTool> getItemList(int appID)
        {
            using (ctx) {
                return ctx.AdditionalTools.Where(adt => adt.ApplicationID == appID).ToList();
            }
        }

        public AdditionalTool getItem(int toolID)
        {
            using (ctx)
            {
                return ctx.AdditionalTools.Find(toolID);
            }
        }

        public void addItem(AdditionalTool addTool)
        {
            using (ctx)
            {
                ctx.AdditionalTools.Add(addTool);
                ctx.SaveChanges();
            }
        }

        public void updateItem(AdditionalTool addTool)
        {
            using (ctx)
            {
                AdditionalTool locTool = ctx.AdditionalTools.Find(addTool.AdditionalToolID);
                locTool.AdditionalToolName = addTool.AdditionalToolName;
                ctx.SaveChanges();
            }
        }

        public List<vwAllAddTool> getAllItemList()
        {
            using (ctx)
            {
                return ctx.vwAllAddTools.ToList();
            }
        }


        public IQueryable<AdditionalTool> getItemListCond(params Expression<Func<AdditionalTool, object>>[] includeProperties)
        {
            using (ctx)
            {
                IQueryable<AdditionalTool> query = ctx.AdditionalTools;
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                return query;
            }
        }
    }
}
