using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class Repository<X, Y> : IItemSL<X, Y>
        where X : class
        where Y : class
    {
        Entities ctx;

        public Repository(Entities newCtx)
        {
            ctx = newCtx;
        }

        public List<X> getItemList(int appID)
        {
            return null; // ctx.Set<X>().Where(it => it.ApplicationID == appID).ToList();
        }

        public X getItem(int itemID)
        {
            throw new NotImplementedException();
        }

        public void addItem(X item)
        {
            throw new NotImplementedException();
        }

        public void updateItem(X item)
        {
            throw new NotImplementedException();
        }

        public List<Y> getAllItemList()
        {
            throw new NotImplementedException();
        }


        public IQueryable<X> getItemListCond(params System.Linq.Expressions.Expression<Func<X, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
