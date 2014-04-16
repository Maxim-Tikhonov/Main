using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTestApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string model = "Кавабунга";
            var mdl = "dsd";
            dynamic testVariable=new Guid();
            testVariable.SetValue();
            return View( viewName:"Index",model: model);

        }

    }
}
