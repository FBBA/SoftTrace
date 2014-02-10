using Ninject;
using SATrackingDAL;
using SATrackingSL;
using SATrakingBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SATracking.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        public void AddBindings() {
            ninjectKernel.Bind<IOrganization>().To<OrganizationBL>();
            ninjectKernel.Bind<IApplication>().To<ApplicationBL>();
            ninjectKernel.Bind<IItemSL<DevelopmentLanguage, vwAllLanguage>>().To<DevelopmentLanguageBL>();
            ninjectKernel.Bind<IItemSL<ApplicationMethodology, vwAllMethodology>>().To<ApplicationMethodologyBL>();
            ninjectKernel.Bind<IItemComlexSL<DataSource, vwAllDataSource, vwDataSource>>().To<DataSourceBL>();//.WithConstructorArgument("val",6)
            ninjectKernel.Bind<IItemComlexSL<DeploymentServer, vwAllDeploymentServer, vwDeploymentServer>>().To<DeploymentServerBL>();
            ninjectKernel.Bind<IItemSL<AdditionalTool, vwAllAddTool>>().To<AdditionalToolBL>();
            ninjectKernel.Bind<IItemSL<FrameworkUsed, vwAllFramework>>().To<FrameworkUsedBL>();
            ninjectKernel.Bind<IItemSL<SkillsRequired, vwAllSkill>>().To<SkillsRequiredBL>();
        }

    }
}