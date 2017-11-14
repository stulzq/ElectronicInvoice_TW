﻿using ElectronicInvoice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicInvoice.Controllers
{
    public class InvoiceController : Controller
    {
        private EIvoiceService service = new EIvoiceService();

        public ActionResult QryWinningList()
        {
            var resultModel = service.GetWinningList("10604");
            return View(resultModel);
        }

        public ActionResult qryInvDetail()
        {
            return View();
        }

        public ActionResult CarrierTitle()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult CarrierTitle(CarrierTilteModel model)
        //{
        //    var result = service.GetInvoice(model);
        //    return View("CarrierTitleResult", result);
        //}

        //[HttpPost]
        //public ActionResult qryInvDetail()
        //{
        //    return View();
        //    //var api = factory.GetInstace(model);
        //    //var result = api.ExcuteApi(model);
        //    //return Content(result);
        //}
    }
}