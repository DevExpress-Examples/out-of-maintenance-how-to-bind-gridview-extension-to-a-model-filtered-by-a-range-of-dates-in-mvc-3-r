using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using System.Web.Script.Serialization;
using System.Globalization;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            //default data
            OrdersModel model = new OrdersModel {
                StartDate = new DateTime(1996, 8, 1),
                EndDate = new DateTime(1996, 8, 30)
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult GridViewPartial() {
            OrdersModel model = new OrdersModel {
                StartDate = DateTime.ParseExact(Request.Params["StartDate"], "d|M|yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact(Request.Params["EndDate"], "d|M|yyyy", CultureInfo.InvariantCulture)
            };
            
            return PartialView("_GridView", model.Data);
        }
    }
}
