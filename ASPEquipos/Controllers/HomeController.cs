using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPEquipos.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //string servicio = "http://localhost:18677/api/Equipoes";
            //var httpClient = new HttpClient();
            //var json = await httpClient.GetStringAsync(servicio);

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
    }
}