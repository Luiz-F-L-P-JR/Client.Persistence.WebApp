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
        [HttpGet("logradouro")]
        public async Task<IActionResult> Index()
        {
            return View(await _publicAreaService.GetAllAsync());
        }

        // GET: PublicAreaController/Details/5
        [HttpGet("logradouro/detalhe")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _publicAreaService.GetAsync(id));
        }

        // GET: PublicAreaController/Create
        [HttpGet("logradoura/adicionar")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: PublicAreaController/Create
        [HttpPost("logradoura/adicionar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Core.PublicArea.Model.PublicArea entity)
        {
            if (ModelState.IsValid)
            {
                await _publicAreaService.CreateAsync(entity);
                return await Index();
            }

            return await Index();
        }

        // GET: PublicAreaController/Edit/5
        [HttpGet("logradouro/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _publicAreaService.GetAsync(id));
        }

        // POST: PublicAreaController/Edit/5
        [HttpPut("logradouro/editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Core.PublicArea.Model.PublicArea entity)
        {
            if (ModelState.IsValid)
            {
                await _publicAreaService.UpdateAsync(entity);
                return await Index();
            }

            return await Index();
        }

        // GET: PublicAreaController/Delete/5
        [HttpGet("logradouro/deletar"), ActionName("Delete")]
        public async Task<IActionResult> DeleteView(int id)
        {
            return View(await _publicAreaService.GetAsync(id));
        }

        // POST: PublicAreaController/Delete/5
        [HttpDelete("logradouro/deletar"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _publicAreaService.DeleteAsync(id);
            return await Index();
        }
    }
}
