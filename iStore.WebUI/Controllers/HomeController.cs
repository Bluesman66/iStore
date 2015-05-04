using System;
using System.Web.Mvc;
using iStore.Domain.Abstract;

namespace iStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _repository;

        public HomeController(IStoreRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Where()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}