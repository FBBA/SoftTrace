using AutoMapper;
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
    public class MethodologyController : Controller
    {
        private IItemSL<ApplicationMethodology, vwAllMethodology> blMthd;

        public MethodologyController(IItemSL<ApplicationMethodology, vwAllMethodology> newMthd)
        {
            blMthd = newMthd;
        }

        public ActionResult Index(int appID)
        {
            return View(blMthd.getItemList(appID));
        }

        public ActionResult All()
        {
            return View(blMthd.getAllItemList());
        }



        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create(int appID)
        {
            return View(new ApplicationMethodologyDTO());
        }

        //
        // POST: /Methodology/Create

        [HttpPost]
        public ActionResult Create(int appID, ApplicationMethodologyDTO locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    locModel.ApplicationID = appID;
                    Mapper.CreateMap<ApplicationMethodologyDTO, ApplicationMethodology>();
                    ApplicationMethodology mthd = Mapper.Map<ApplicationMethodologyDTO, ApplicationMethodology>(locModel);
                    blMthd.addItem(mthd);
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
        // GET: /Methodology/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Methodology/Edit/5

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
        // GET: /Methodology/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Methodology/Delete/5

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
