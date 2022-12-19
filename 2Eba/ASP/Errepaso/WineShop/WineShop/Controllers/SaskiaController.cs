using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WineShop.Controllers
{
    public class SaskiaController : Controller
    {
        // GET: SaskiaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SaskiaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaskiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaskiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaskiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaskiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaskiaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaskiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
