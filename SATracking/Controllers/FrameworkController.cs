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
    public class FrameworkController : Controller
    {
        IItemSL<FrameworkUsed, vwAllFramework> blFrm;

        public FrameworkController(IItemSL<FrameworkUsed, vwAllFramework> newFrm) {
            blFrm = newFrm;
        }

        public ActionResult Index(int appID)
        {
            return View(blFrm.getItemList(appID));
        }

        public ActionResult All()
        {
            return View(blFrm.getAllItemList());
        }

        //
        // GET: /Framework/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Framework/Create

        public ActionResult Create(int appID)
        {
            return View(new FrameworkUsedDTO());
        }

        //
        // POST: /Framework/Create

        [HttpPost]
        public ActionResult Create(int appID, FrameworkUsedDTO locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    FrameworkUsed frm = new FrameworkUsed();
                    frm.ApplicationID = appID;
                    frm.FrameworkName = locModel.FrameworkName;
                    blFrm.addItem(frm);
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
        // GET: /Framework/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Framework/Edit/5

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
        // GET: /Framework/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Framework/Delete/5

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
