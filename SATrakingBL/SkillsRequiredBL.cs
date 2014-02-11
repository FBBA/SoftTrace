using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class SkillsRequiredBL : IItemSL<SkillsRequired, vwAllSkill>
    {
        Entities ctx;

        public SkillsRequiredBL(Entities newCtx)
        {
            ctx = newCtx;
        }

        public List<SkillsRequired> getItemList(int appID)
        {
            using (ctx) {
               return ctx.Set<SkillsRequired>().Where(sk => sk.ApplicationID == appID).ToList();
            }
        }

        public SkillsRequired getItem(int itemID)
        {
            using (ctx) {
                return ctx.Set<SkillsRequired>().Find(itemID);
            }
        }

        public void addItem(SkillsRequired item)
        {
            using (ctx) {
                ctx.Set<SkillsRequired>().Add(item);
                ctx.SaveChanges();
            }
        }

        public void updateItem(SkillsRequired item)
        {
            using (ctx) {
                SkillsRequired locItem = ctx.Set<SkillsRequired>().Find(item.ApplicationID);
                locItem.SkillName = item.SkillName;
                ctx.SaveChanges();
            }
        }

        public List<vwAllSkill> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllSkill>().ToList();
            }
        }


        public IQueryable<SkillsRequired> getItemListCond(params System.Linq.Expressions.Expression<Func<SkillsRequired, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
