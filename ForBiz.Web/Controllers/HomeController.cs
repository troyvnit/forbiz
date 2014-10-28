using System;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using ForBiz.Entities.Models;
using ForBiz.Service;
using ForBiz.Web.Models;
using Repository.Pattern.UnitOfWork;
using Repository.Pattern.Infrastructure;

namespace ForBiz.Web.Controllers
{
    public class HomeController : Controller
    {
        private IQuickLinkService quickLinkService { get; set; }
        private IArticleService articleService { get; set; }
        private IUnitOfWorkAsync unitOfWork { get; set; }
        private IArticleCategoryService articleCategoryService { get; set; }

        public HomeController(IQuickLinkService quickLinkService, IUnitOfWorkAsync unitOfWork, IArticleService articleService, IArticleCategoryService articleCategoryService)
        {
            this.quickLinkService = quickLinkService;
            this.articleService = articleService;
            this.unitOfWork = unitOfWork;
            this.articleCategoryService = articleCategoryService;
        }
        public ActionResult Index()
        {
            var xmlReader = XmlReader.Create("http://vnexpress.net/rss/so-hoa.rss");
            var feed = SyndicationFeed.Load(xmlReader);
            xmlReader.Close();
            if (feed != null) ViewBag.FeedItems = feed.Items.Take(10);
            //foreach(var feedItem in feed.Items){
            //    var doc = new HtmlAgilityPack.HtmlDocument();
            //    doc.LoadHtml(feedItem.Summary.Text);
            //    var avatar = @doc.DocumentNode.Descendants("img").Select(n => n.Attributes["src"].Value).ToArray().FirstOrDefault();
            //    articleService.Insert(new Article
            //    {
            //        Author = "Số Hóa",
            //        Avatar = avatar,
            //        CreatedDate = DateTime.Now,
            //        Description = feedItem.Summary.Text,
            //        PublishedDate = DateTime.Now,
            //        Title = feedItem.Title.Text,
            //        ObjectState = ObjectState.Added
            //    });
            //}
            //unitOfWork.SaveChangesAsync();
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