using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ararat_Reports.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Add_Report(FormCollection values, HttpPostedFileBase image)
        {
            if (image != null)
            {
                string pic = System.IO.Path.GetFileName(image.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/img/reports"), pic);
                // file is uploaded
                image.SaveAs(path);

            }

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