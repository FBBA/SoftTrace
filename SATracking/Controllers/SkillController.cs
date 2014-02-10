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
    public class SkillController : Controller
    {
        IItemSL<SkillsRequired, vwAllSkill> blSkill;

        public SkillController(IItemSL<SkillsRequired, vwAllSkill> newBL)
        {
            blSkill = newBL;
        }

        public ActionResult Index(int appID)
        {
            return View(blSkill.getItemList(appID));
        }

        public ActionResult All()
        {
            return View(blSkill.getAllItemList());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Skill/Create

        public ActionResult Create()
        {
            return View(new SkillsRequiredDTO());
        }

        //
        // POST: /Skill/Create

        [HttpPost]
        public ActionResult Create(int appID, SkillsRequiredDTO locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SkillsRequired sk = new SkillsRequired();
                    sk.ApplicationID = appID;
                    sk.SkillName = locModel.SkillName;
                    blSkill.addItem(sk);
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
        // GET: /Skill/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Skill/Edit/5

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
        // GET: /Skill/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Skill/Delete/5

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
