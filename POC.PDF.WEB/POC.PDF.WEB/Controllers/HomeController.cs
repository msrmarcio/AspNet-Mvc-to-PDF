using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTextSharp.text;
using POC.PDF.WEB.Domain;

namespace POC.PDF.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult teste(string id)
        {
            var _return = new List<string>();

            try
            {
                ManagerPdf obj = new ManagerPdf();

                obj.gerarPdf();

                
            }
            catch (Exception ex)
            {
                 
            }

            return View();
        }

        public ActionResult ViewPDF()
        {
            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"500px\" height=\"300px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            TempData["Embed"] = string.Format(embed, VirtualPathUtility.ToAbsolute("~/Files/Mudassar_Khan.pdf"));

            return View();
        }

        [HttpPost]
        public ActionResult ViewPDF(string id)
        {
            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"500px\" height=\"300px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            TempData["Embed"] = string.Format(embed, VirtualPathUtility.ToAbsolute("~/Files/Mudassar_Khan.pdf"));

            //return RedirectToAction("Index");
            return View();
        }

        [HttpGet]
        public ActionResult ContractPerHour()
        {
            return View();
        }
    } 
}