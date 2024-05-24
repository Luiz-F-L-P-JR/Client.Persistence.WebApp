using Client.Persistence.Core.PublicArea.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Client.Persistence.WebApp.Controllers
{
    public class PublicAreaController : Controller
    {
        private readonly IPublicAreaService? _publicAreaService;

        public PublicAreaController(IPublicAreaService? publicAreaService)
        {
            _publicAreaService = publicAreaService;
        }

        // GET: PublicAreaController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _publicAreaService.GetAllAsync());
        }

        // GET: PublicAreaController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PublicAreaController/Create
        [HttpGet("Create")]
        public ActionResult CreateView()
        {
            return View();
        }

        // POST: PublicAreaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Core.PublicArea.Model.PublicArea entity)
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

        // GET: PublicAreaController/Edit/5
        [HttpGet("Edit")]
        public ActionResult EditView(int id)
        {
            return View();
        }

        // POST: PublicAreaController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Core.PublicArea.Model.PublicArea entity)
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

        // GET: PublicAreaController/Delete/5
        [HttpGet("Delete")]
        public ActionResult DeleteView(int id)
        {
            return View();
        }

        // POST: PublicAreaController/Delete/5
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
