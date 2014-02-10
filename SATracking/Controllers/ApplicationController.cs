using AutoMapper;
using SATracking.Models;
using SATrackingDAL;
using SATrackingDomain;
using SATrackingSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Controllers
{
    public class ApplicationController : Controller
    {
        private IApplication blApp;
        private IOrganization blOrg;
        

        public ApplicationController(IApplication newApp, IOrganization newOrg)
        {
            blApp = newApp;
            blOrg = newOrg;
        }

        //param is the parameter
        //src - source of the parameter, Language, Methodology, etc...
        public ActionResult Index(string param, string src)
        {
            string locPrm = "";
            string locSrc = "";
            if (param != null) { locPrm = param; locSrc = src; }
            return View(blApp.getAppList(locPrm, locSrc));
        }

        //
        // GET: /Application/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Create()
        {
            ApplicationModel appModel = new ApplicationModel();
            appModel.dtoApp = new ApplicationDTO();
            appModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
            return View(appModel);
        }

        [HttpPost]
        public ActionResult Create(ApplicationModel locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Mapper.CreateMap<ApplicationDTO, Application>();
                    Application app = Mapper.Map<ApplicationDTO, Application>(locModel.dtoApp);
                    blApp.saveApplication(app);
                    return RedirectToAction("Index");
                }
                else
                {
                    locModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
                    return View(locModel);
                }
            }
            catch
            {
                locModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
                return View(locModel);
            }
        }

        //
        // GET: /Application/Edit/5

        public ActionResult Edit(int appID)
        {
            ApplicationModel appModel = new ApplicationModel();
            Application app = blApp.getApplication(appID);
            Mapper.CreateMap<Application, ApplicationDTO>();
            appModel.dtoApp = Mapper.Map<Application, ApplicationDTO>(app);
            appModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
            return View(appModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int appID, ApplicationModel locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Mapper.CreateMap<ApplicationDTO, Application>();
                    Application app = Mapper.Map<ApplicationDTO, Application>(locModel.dtoApp);
                    blApp.updateApplication(app);
                    return RedirectToAction("Index");
                }
                else
                {
                    locModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
                    return View(locModel);
                }
            }
            catch
            {
                locModel.orgList = new SelectList(blOrg.getOrgList(), "OrganizationID", "OrganizationName");
                return View(locModel);
            }
        }

        //
        // GET: /Application/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Application/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
