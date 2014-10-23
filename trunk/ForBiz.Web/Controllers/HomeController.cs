using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using ForBiz.Entities.Models;
using ForBiz.Service;
using Repository.Pattern.UnitOfWork;

namespace ForBiz.Web.Controllers
{
    public class HomeController : Controller
    {
        private IQuickLinkService quickLinkService { get; set; }
        private IUnitOfWorkAsync unitOfWork { get; set; }

        public HomeController(IQuickLinkService quickLinkService, IUnitOfWorkAsync unitOfWork)
        {
            this.quickLinkService = quickLinkService;
            this.unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var xmlReader = XmlReader.Create("http://vnexpress.net/rss/so-hoa.rss");
            var feed = SyndicationFeed.Load(xmlReader);
            xmlReader.Close();
            if (feed != null) ViewBag.FeedItems = feed.Items;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult _Menu()
        {
            return PartialView();
        }
    }
}