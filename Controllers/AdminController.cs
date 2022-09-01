using myproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace myproject.Controllers
{
    public class AdminController : ApiController
    {
        Bal bal = new Bal();
          public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [System.Web.Http.HttpPost]
        public ActionResult Register(Register register)
        {
            String response = bal.Register(register);
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        private ActionResult Json(string response, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
