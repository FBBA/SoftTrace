using SATrackingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class UtilitiesBL
    {
        public static List<State> getStateList() {
            using (Entities ctx = new Entities()) {
                return ctx.States.ToList();
            }
        }

        public static List<ApplicationEnvironment> getEnvironmentList() {
            using (Entities ctx = new Entities())
            {
                return ctx.Set<ApplicationEnvironment>().ToList();
            }
        }
    }
}
