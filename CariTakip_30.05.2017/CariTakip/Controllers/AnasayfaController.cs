using CariTakip.InfraStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CariTakip.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAttribute("anasayfa")]
    public class AnasayfaController : Controller
    {
        //
        // GET: /Anasayfa/

    
        public ActionResult Index()
        {
            return View();
        }
	}
}