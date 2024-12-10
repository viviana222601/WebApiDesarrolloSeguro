using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDesarrolloSeguro.Controllers
{
    public class ValidaDatosController : Controller
    {
        // GET: ValidaDatos
        public ActionResult Index()
        {
            return View();
        }

        // GET: ValidaDatos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValidaDatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValidaDatos/Create
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

        // GET: ValidaDatos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValidaDatos/Edit/5
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

        // GET: ValidaDatos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValidaDatos/Delete/5
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
