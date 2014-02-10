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
    public class DataSourceController : Controller
    {
        private IItemComlexSL<DataSource, vwAllDataSource, vwDataSource> blDS;

        public DataSourceController(IItemComlexSL<DataSource, vwAllDataSource, vwDataSource> newDS)
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
        // GET: /DataSource/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create(int appID)
        {
            DataSourceModel dsModel = new DataSourceModel();
            dsModel.dtoDS = new DataSourceDTO();
            dsModel.appEnvList = new SelectList(UtilitiesBL.getEnvironmentList(), "ApplicationEnvironmentID", "ApplicationEnvironmentName");
            return View(dsModel);
        }


        [HttpPost]
        public ActionResult Create(int appID, DataSourceModel locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DataSource ds = new DataSource();
                    ds.ApplicationID = appID;
                    ds.ApplicationEnvironmentID = locModel.dtoDS.ApplicationEnvironmentID;
                    ds.DataSourceName = locModel.dtoDS.DataSourceName;
                    ds.DataSourceType = locModel.dtoDS.DataSourceType;
                    ds.SchemaName = locModel.dtoDS.SchemaName;
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
        // GET: /DataSource/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DataSource/Edit/5

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
        // GET: /DataSource/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DataSource/Delete/5

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
