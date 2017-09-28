using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTextSharp.text;
using POC.PDF.WEB.Domain;
using POC.PDF.WEB.Models;

namespace POC.PDF.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Nome = "MARCIO DOS SANTOS RODRIGUES";


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

        [HttpGet]
        public ActionResult DetalheReservas()
        {
            ReservasViewModel obj = new ReservasViewModel();
            obj.Mensagem = "MARCIO DOS SANTOS RODRIGUES = WORK IN HUB";



            return View(obj);
        }

        [HttpGet]
        public ActionResult NEW_ContractPerHour()
        {
            ReservasViewModel obj = new ReservasViewModel();
            obj.Mensagem = "MARCIO DOS SANTOS RODRIGUES = WORK IN HUB";



            return View(obj);
        }

        public ActionResult teste()
        {
            var _return = new List<string>();

            try
            {
                ReservasViewModel reserva = new ReservasViewModel();
                reserva.Mensagem = "MARCIO DOS SANTOS RODRIGUES = WORK IN HUB";


                return new ActionAsPdf("ContractPerHour", new { name = "Giorgio" }) { FileName = "Test.pdf" };
                //return new ActionAsPdf("Index", new { name = "Giorgio" }) { FileName = "Test.pdf" };

                ManagerPdf obj = new ManagerPdf();

                obj.gerarPdf();


            }
            catch (Exception ex)
            {

            }

            return View();
        }

        public ActionResult PdfNewContrato()
        {
            var _return = new List<string>();

            try
            {
                ReservasViewModel reservas = new ReservasViewModel();

                reservas.TotalCarrinho = "XXX - MARCIO DOS SANTOS RODRIGUES";

                return new ActionAsPdf("NEW_ContractPerHour", new { name = "MARCIO" }) { FileName = "Test.pdf" };
                //return new ActionAsPdf("Index", new { name = "Giorgio" }) { FileName = "Test.pdf" };

                ManagerPdf obj = new ManagerPdf();

                obj.gerarPdf();


            }
            catch (Exception ex)
            {

            }

            return View();
        }

        public ActionResult PdfDetalheReserva()
        {
            var _return = new List<string>();

            try
            {
                ReservasViewModel reservas = new ReservasViewModel();

                reservas.TotalCarrinho = "MARCIO DOS SANTOS RODRIGUES";
                                
                return new ActionAsPdf("DetalheReservas", new { name = "MARCIO" }) { FileName = "Test.pdf" };
                //return new ActionAsPdf("Index", new { name = "Giorgio" }) { FileName = "Test.pdf" };

                ManagerPdf obj = new ManagerPdf();

                obj.gerarPdf();


            }
            catch (Exception ex)
            {

            }

            return View();
        }
    } 
}