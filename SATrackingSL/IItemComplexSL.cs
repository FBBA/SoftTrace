using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrackingSL
{
    public interface IItemComlexSL<X, Y, Z>
    {
        List<Z> getItemList(int appID);
        X getItem(int itemID);
        void addItem(X item);
        void updateItem(X item);
        List<Y> getAllItemList();
    }
}
