using RealEstate_Management.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RealEstate_Management.Controllers
{
    public class MasterController : Controller
    {
        private Contextdb db = new Contextdb();
        // GET: Master
        public ActionResult BannerMaster()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BannerMaster(BannerMaster Banner, HttpPostedFileBase BannerImage)
        {
            if (ModelState.IsValid)
            {
                if (BannerImage != null && BannerImage.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(BannerImage.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/BannerImages/"), fileName);
                    BannerImage.SaveAs(path);
                    Banner.Banner_Image = fileName;
                }

                db.Banners.Add(Banner);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new BannerMaster());
            }
            return View(Banner);
        }
        public ActionResult PropertyTypeMaster()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PropertyTypeMaster(PropertyTypeMaster PropertyType)
        {
            if (ModelState.IsValid)
            {
                

                db.PropertyTypes.Add(PropertyType);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new PropertyTypeMaster());
            }
            return View(PropertyType);
        }


        public ActionResult PerfectPropertyMaster()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PerfectPropertyMaster(PerfectPropertyMaster PerfectProperty, HttpPostedFileBase Property_Image)
        {
            if (ModelState.IsValid)
            {
                if (Property_Image != null && Property_Image.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(Property_Image.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/PropertyImages/"), fileName);
                    Property_Image.SaveAs(path);
                    PerfectProperty.Property_Image = fileName;
                }

                db.PerfectProperties.Add(PerfectProperty);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new PerfectPropertyMaster());
            }
            return View(PerfectProperty);
        }
        public ActionResult PropertyListingMaster()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PropertyListingMaster(PropertyListingMaster propertyListing, HttpPostedFileBase PropertyList_Image)
        {
            if (ModelState.IsValid)
            {
                if (PropertyList_Image != null && PropertyList_Image.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(PropertyList_Image.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/ListingImages/"), fileName);
                    PropertyList_Image.SaveAs(path);
                    propertyListing.PropertyList_Image = fileName;
                }

                
                db.PropertyLists.Add(propertyListing);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new PropertyListingMaster());
            }
            return View(propertyListing);
        }

        public ActionResult PropertyAgentMaster()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PropertyAgentMaster(PropertyAgentMaster PropertyAgent, HttpPostedFileBase Agent_Image)
        {
            if (ModelState.IsValid)
            {
                if (Agent_Image != null && Agent_Image.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(Agent_Image.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/PropertyAgents/"), fileName);
                    Agent_Image.SaveAs(path);
                    PropertyAgent.Agent_Image = fileName;
                }

                db.PropertyAgents.Add(PropertyAgent);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new PropertyAgentMaster());
            }
            return View(PropertyAgent);
        }
        public ActionResult PropertyClientMaster()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PropertyClientMaster(PropertyClientMaster PropertyClient, HttpPostedFileBase Client_image)
        {
            if (ModelState.IsValid)
            {
                if (Client_image != null && Client_image.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(Client_image.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/PropertyClients/"), fileName);
                    Client_image.SaveAs(path);
                    PropertyClient.Client_image = fileName;
                }

                db.PropertyClients.Add(PropertyClient);
                db.SaveChanges();
                ViewBag.Success = true;
                ModelState.Clear();
                return View(new PropertyClientMaster());
            }
            return View(PropertyClient);
        }
    }
}