using AutoMapper;
using SATrackingDAL;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class ApplicationBL : IApplication
    {
        Entities ctx;

        public ApplicationBL(Entities newCtx) {
            ctx = newCtx;
        }

        public SATrackingDAL.Application getApplication(int AppID)
        {
            using (ctx) {
                return ctx.Set<Application>().Find(AppID);
            }
        }

        public List<SATrackingDAL.Application> getAppList(string param, string src)
        {
            List<int> appID;

            using (ctx) {
                switch (src)
                {
                    case "":
                        return ctx.Applications.ToList();

                    case "lng":
                        appID = ctx.DevelopmentLanguages.Where(lng => lng.LanguageName.Contains(param)).Select(lng => lng.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    case "mthd":
                        appID = ctx.ApplicationMethodologies.Where(mthd => mthd.ApplicationMethodologyText.Contains(param)).Select(mthd => mthd.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();
                    
                    case "ds":
                        appID = ctx.DataSources.Where(ds => ds.DataSourceName.Contains(param)).Select(ds => ds.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    case "deps":
                        appID = ctx.DeploymentServers.Where(ds => ds.DeploymentServerName.Contains(param)).Select(ds => ds.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    case "tool":
                        appID = ctx.AdditionalTools.Where(ds => ds.AdditionalToolName.Contains(param)).Select(ds => ds.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    case "frm":
                        appID = ctx.FrameworkUseds.Where(ds => ds.FrameworkName.Contains(param)).Select(ds => ds.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    case "sk":
                        appID = ctx.SkillsRequireds.Where(ds => ds.SkillName.Contains(param)).Select(ds => ds.ApplicationID).ToList();
                        return ctx.Applications.Where(app => appID.Contains(app.ApplicationID)).ToList();

                    default:
                        return ctx.Applications.ToList();
                }
            }
        }



        public void saveApplication(SATrackingDAL.Application app)
        {
            using (ctx) {
                ctx.Set<Application>().Add(app);
                ctx.SaveChanges();
            }
        }

        public void updateApplication(SATrackingDAL.Application app)
        {
            using (ctx)
            {
                Application locApp = ctx.Set<Application>().Find(app.ApplicationID);
                //Mapper.CreateMap<Application, Application>().ForMember("ApplicationID", r=>r.Ignore()).ForMember("OrganizationID",r=>r.Ignore());
                //locApp = Mapper.Map(app, locApp);
                locApp.OrganizationID = app.OrganizationID;
                locApp.ApplicationName = app.ApplicationName;
                locApp.ApplicationEnvironment = app.ApplicationEnvironment;
                locApp.DevelopingCompany = app.DevelopingCompany;
                locApp.ProjectManager = app.ProjectManager;
                locApp.OperatingSystem = app.OperatingSystem;
                locApp.IDE = app.IDE;
                locApp.VersionControlTool = app.VersionControlTool;
                locApp.VersionControlPath = app.VersionControlPath;
                locApp.ApplicationType = app.ApplicationType;
                locApp.UnitTestTool = app.UnitTestTool;
                locApp.DeployementTool = app.DeployementTool;
                locApp.DeployedDate = app.DeployedDate;
                locApp.OutsideApplication = app.OutsideApplication;
                locApp.Comment = app.Comment;

                ctx.SaveChanges();
            }
        }

    }
}
