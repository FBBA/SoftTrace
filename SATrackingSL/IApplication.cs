using SATrackingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrackingSL
{
    public interface IApplication
    {
        Application getApplication(int AppID);
        List<Application> getAppList(string param, string src);
        void saveApplication(Application app);
        void updateApplication(Application app);
    }
}
