using Microsoft.AspNetCore.Mvc;

namespace Client.Persistence.WebApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        [HttpGet("Create")]
        public ActionResult CreateView()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Core.Client.Model.Client entity)
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

        // GET: ClientController/Edit/5
        [HttpGet("Edit")]
        public ActionResult EditView(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Core.Client.Model.Client entity)
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

        // GET: ClientController/Delete/5
        [HttpGet("Delete")]
        public ActionResult DeleteView(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
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
