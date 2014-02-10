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
    public class AdditionalToolController : Controller
    {
        IItemSL<AdditionalTool, vwAllAddTool> blTool;

        public AdditionalToolController(IItemSL<AdditionalTool, vwAllAddTool> newTool)
        {
            blTool = newTool;
        }

        public ActionResult Index(int appID)
        {
            return View(blTool.getItemList(appID));
        }

        public ActionResult All()
        {
            return View(blTool.getAllItemList());
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /AdditionalTool/Create

        public ActionResult Create(int appID)
        {
            return View(new AdditionalToolsDTO());
        }

        //
        // POST: /AdditionalTool/Create

        [HttpPost]
        public ActionResult Create(int appID, AdditionalToolsDTO locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    locModel.ApplicationID = appID;
                    AdditionalTool tool = new AdditionalTool();
                    tool.ApplicationID = appID;
                    tool.AdditionalToolName = locModel.AdditionalToolName;
                    blTool.addItem(tool);
                    return RedirectToAction("Index", new { appID = Request.QueryString["appID"] });
                }
                else
                {
                    return View(locModel);
                }
            }
            catch
            {
                return View(locModel);
            }
        }

        //
        // GET: /AdditionalTool/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /AdditionalTool/Edit/5

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
        // GET: /AdditionalTool/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /AdditionalTool/Delete/5

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
