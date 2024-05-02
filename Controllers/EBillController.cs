using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EBillApplication.Models;
using EBillApplication.Repositery;

namespace EBillApplication.Controllers
{
    public class EBillController : Controller
    {
        // GET: EBill
        public ActionResult Index()
        {
            Data data = new Data();
            var list = data.GetAllDetails();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(BillDetails details)
        {
            Data data = new Data();
            data.SaveBillDetails(details);
            ModelState.Clear();
            return View();
        }

        public ActionResult CreateItem(Items item)
        {
            return PartialView("_CreateItem",item);
        }

        public ActionResult ViewBill(int id)
        {
            Data data = new Data();
            var detail = data.GetDetail(id);
            return View(detail);
        }

    }
}