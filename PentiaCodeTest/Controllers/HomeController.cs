using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using LinqKit;
using PentiaCodeTest.Models;
using PentiaCodeTest.Services;

namespace PentiaCodeTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesContext _db = new SalesContext();
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Customers = _db.Persons.OfType<Customer>(),
                CustomerSearchModel = new CustomerSearchFormViewModel
                {
                    CarMakes = _db.CarMakes.ToList(),
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var predicate = SearchService.GetCustomerSearchPredicate(model.CustomerSearchModel);
            model.Customers = _db.Persons.OfType<Customer>().AsExpandable().Where(predicate).ToList();
            model.CustomerSearchModel.CarMakes = _db.CarMakes.ToList();
            return View(model);
        }

        public ActionResult CarModels(int carMakeId = 0)
        {
            return Json(_db.CarModels.Where(a => a.CarMakeId == carMakeId).OrderBy(a => a.Id).Select(a => new { a.Id, a.Name}), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(IndexViewModel model)
        {
            var predicate = SearchService.GetCustomerSearchPredicate(model.CustomerSearchModel);
            model.Customers = _db.Persons.OfType<Customer>().AsExpandable().Where(predicate).ToList();

            return PartialView("_CustomerList", model);
        }
    }
}