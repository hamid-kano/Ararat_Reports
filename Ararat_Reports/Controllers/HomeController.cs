using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ararat_Reports.Controllers
{
    public class HomeController : Controller
    {
        Ararat_ReportEntities DB = new Ararat_ReportEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult catagory()
        {
            return View();
        }
        public ActionResult single_blog()
        {
            return View();
        }
        public ActionResult Add_Report()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Report(FormCollection values)
        {
            string path="";
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = System.IO.Path.GetFileName(file.FileName);
                     path = System.IO.Path.Combine(Server.MapPath("~/img/reports"), fileName);
                    file.SaveAs(path);
                }
            }
            Report report = new Report();
            report.nameReport = values["name"];
            report.contentReport = values["message"];
            report.imageURL = path;
            report.dateTime = DateTime.Now;
            report.user_id = 0;
            DB.Reports.Add(report);
            DB.SaveChanges();
            return View();
        }
        public ActionResult regular_page()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}