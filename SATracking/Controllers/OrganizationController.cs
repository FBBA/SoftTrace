using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SATrackingDAL;
using SATrackingDomain;
using SATrackingSL;
using SATracking.Domain;
using AutoMapper;
using SATracking.Models;
using SATrakingBL;

namespace SATracking.Controllers
{
    public class OrganizationController : Controller
    {
        private IOrganization blOrg;

        public OrganizationController(IOrganization newOrg) {
            blOrg = newOrg;
        }

        public ActionResult List()
        {
            return View(blOrg.getOrgList());
        }


        public ActionResult Details(int id)
        {
            Organization org = blOrg.getOrganization(id);
            Mapper.CreateMap<Organization, OrganizationDTO>();
            OrganizationDTO dtoOrg = Mapper.Map<Organization, OrganizationDTO>(org);
            return View(dtoOrg);
        }

        //
        // GET: /Organization/Create

        public ActionResult Create()
        {
            OrganizationModel orgModel = new OrganizationModel();
            orgModel.dtoOrg = new OrganizationDTO();
            orgModel.stateList = new SelectList(UtilitiesBL.getStateList(), "StateCode", "StateName");
            return View(orgModel);
        }

        [HttpPost]
        public ActionResult Create(OrganizationModel locModel)
        {

            if (ModelState.IsValid)
            {
                Mapper.CreateMap<OrganizationDTO, Organization>();
                Organization org = Mapper.Map<OrganizationDTO, Organization>(locModel.dtoOrg);
                blOrg.saveOrganization(org);
                return RedirectToAction("List");
            }
            else
            {
                return View(locModel);
            }
        }


        //
        // GET: /Organization/Edit/5

        public ActionResult Edit(int id)
        {
            OrganizationModel orgModel = new OrganizationModel();
            Organization org = blOrg.getOrganization(id);
            Mapper.CreateMap<Organization, OrganizationDTO>();
            orgModel.dtoOrg = Mapper.Map<Organization, OrganizationDTO>(org);
            orgModel.stateList = new SelectList(UtilitiesBL.getStateList(), "StateCode", "StateName");
            return View(orgModel);
        }

        //
        // POST: /Organization/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, OrganizationModel locModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Mapper.CreateMap<OrganizationDTO, Organization>();
                    Organization org = Mapper.Map<OrganizationDTO, Organization>(locModel.dtoOrg);
                    blOrg.updateOrganization(org);
                    return RedirectToAction("List");
                }
                else
                {
                    locModel.stateList = new SelectList(UtilitiesBL.getStateList(), "StateCode", "StateName");
                    return View(locModel);
                }
            }
            catch
            {
                locModel.stateList = new SelectList(UtilitiesBL.getStateList(), "StateCode", "StateName");
                return View(locModel);
            }
        }

        //
        // GET: /Organization/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Organization/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}
