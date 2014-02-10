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
    public class LanguageController : Controller
    {
        private IItemSL<DevelopmentLanguage,vwAllLanguage> blLang;

        public LanguageController(IItemSL<DevelopmentLanguage, vwAllLanguage> newLang)
        {
            blLang = newLang;
        }

        public ActionResult Index(int appID)
        {
            return View(blLang.getItemList(appID));
        }

        public ActionResult All() 
        {
            return View(blLang.getAllItemList());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Language/Create

        public ActionResult Create(int appID)
        {
            return View(new DevelopmentLanguageDTO());
        }

        //
        // POST: /Language/Create

        [HttpPost]
        public ActionResult Create(int appID, DevelopmentLanguageDTO locModel)
        {
            try
            {
                if (ModelState.IsValid){
                    locModel.ApplicationID = appID;
                    Mapper.CreateMap<DevelopmentLanguageDTO, DevelopmentLanguage>();
                    DevelopmentLanguage lng = Mapper.Map<DevelopmentLanguageDTO, DevelopmentLanguage>(locModel);
                    blLang.addItem(lng);
                    return RedirectToAction("Index", new { appID = Request.QueryString["appID"] });
                }
                else {
                    return View(locModel);
                }
            }
            catch
            {
                return View(locModel);
            }
        }

        //
        // GET: /Language/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Language/Edit/5

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
        // GET: /Language/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Language/Delete/5

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
