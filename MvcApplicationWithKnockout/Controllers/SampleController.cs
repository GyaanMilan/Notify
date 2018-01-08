using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationWithKnockout.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string name,string email,string address)
        {
            bool isSave = false;
            if (!string.IsNullOrEmpty(name)&& !string.IsNullOrEmpty(address))
            {
                isSave = true;
            }
            return Json(isSave, JsonRequestBehavior.AllowGet);

        }
    }
}
