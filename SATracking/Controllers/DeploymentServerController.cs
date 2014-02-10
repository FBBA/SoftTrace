using SATracking.Models;
using SATrackingDAL;
using SATrackingDomain;
using SATrackingSL;
using SATrakingBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SATracking.Controllers
{
    public class DeploymentServerController : Controller
    {
        IItemComlexSL<DeploymentServer, vwAllDeploymentServer, vwDeploymentServer> blDS;

        public DeploymentServerController(IItemComlexSL<DeploymentServer, vwAllDeploymentServer, vwDeploymentServer> newDS)
        {
            blDS = newDS;
        }

        public ActionResult Index(int appID)
        {
            return View(blDS.getItemList(appID));
        }

        public ActionResult All()
        {
            return View(blDS.getAllItemList());
        }

        //
        // GET: /DeploymentServer/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DeploymentServer/Create

        public ActionResult Create(int appID)
        {
            DeploymentServerModel dsModel = new DeploymentServerModel();
            dsModel.dtoDS = new DeploymentServerDTO();
            dsModel.appEnvList = new SelectList(UtilitiesBL.getEnvironmentList(), "ApplicationEnvironmentID", "ApplicationEnvironmentName");
            return View(dsModel);
        }

        //
        // POST: /DeploymentServer/Create

        [HttpPost]
        public ActionResult Create(int appID, DeploymentServerModel locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DeploymentServer ds = new DeploymentServer();
                    ds.ApplicationID = appID;
                    ds.ApplicationEnvironmentID = locModel.dtoDS.ApplicationEnvironmentID;
                    ds.DeploymentServerName = locModel.dtoDS.DeploymentServerName;
                    blDS.addItem(ds);
                    return RedirectToAction("Index", new { appID = Request.QueryString["appID"] });
                }
                else
                {
                    locModel.appEnvList = new SelectList(UtilitiesBL.getEnvironmentList(), "ApplicationEnvironmentID", "ApplicationEnvironmentName");
                    return View(locModel);
                }
            }
            catch
            {
                locModel.appEnvList = new SelectList(UtilitiesBL.getEnvironmentList(), "ApplicationEnvironmentID", "ApplicationEnvironmentName");
                return View(locModel);
            }
        }

        //
        // GET: /DeploymentServer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DeploymentServer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DeploymentServer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DeploymentServer/Delete/5

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
