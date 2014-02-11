using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class DevelopmentLanguageBL : IItemSL<DevelopmentLanguage, vwAllLanguage>
    {
        Entities ctx;

        public DevelopmentLanguageBL() {
            ctx = new Entities();
        }

        public List<DevelopmentLanguage> getItemList(int appID)
        {
            using (ctx) {
                return ctx.Set<DevelopmentLanguage>().Where(lng => lng.ApplicationID == appID).ToList();
            }
        }

        public DevelopmentLanguage getItem(int langID)
        {
            using (ctx) {
                return ctx.Set<DevelopmentLanguage>().Find(langID);
            }
        }

        public void addItem(DevelopmentLanguage devLang)
        {
            using (ctx) {
                ctx.Set<DevelopmentLanguage>().Add(devLang);
                ctx.SaveChanges();
            }
        }

        public void updateItem(DevelopmentLanguage devLang)
        {
            using (ctx) {
                DevelopmentLanguage locLang = ctx.Set<DevelopmentLanguage>().Find(devLang.LanguageID);
                locLang.LanguageName = devLang.LanguageName;
                ctx.SaveChanges();
            }
        }

        public List<vwAllLanguage> getAllItemList()
        {
            using (ctx) {
                return ctx.Set<vwAllLanguage>().ToList();
            }
        }

        //public static IEnumerable<DevelopmentLanguage> GetWhere(Expression<Func<DevelopmentLanguage, bool>> where, int numDesired)
        //{
        //    Func<DevelopmentLanguage, bool> funcWhere = where.Compile();
            
        //}


        public IQueryable<DevelopmentLanguage> getItemListCond(params Expression<Func<DevelopmentLanguage, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }//end of class

}
