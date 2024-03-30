using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class DronController : Controller
    {
        // GET: DronController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DronController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DronController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DronController/Create
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

        // GET: DronController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DronController/Edit/5
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

        // GET: DronController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DronController/Delete/5
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
