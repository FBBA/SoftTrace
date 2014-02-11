using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SATrackingSL
{
    public interface IItemSL<X,Y> 
        where X:class 
        where Y:class
    {
        List<X> getItemList(int appID);
        IQueryable<X> getItemListCond(params Expression<Func<X,object>>[] includeProperties);
        X getItem(int itemID);
        void addItem(X item);
        void updateItem(X item);
        List<Y> getAllItemList();
    }
}
