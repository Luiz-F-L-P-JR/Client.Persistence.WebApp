using Client.Persistence.Core.Client.Service.Interface;
using Client.Persistence.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.Persistence.WebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService? _clientservice;

        public ClientController(IClientService? clientservice)
        {
            _clientservice = clientservice;
        }

        // GET: ClientController
        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            return View(await _clientservice.GetAllAsync());
        }

        // GET: ClientController/Details/5
        [HttpGet("cliente/detalhe")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _clientservice.GetWithPublicAreaAsync(id));
        }

        // GET: ClientController/Create
        [HttpGet("cliente/adicionar")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost("cliente/adicionar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersistenceViewModel entity)
        {
            entity.Client.PublicAreas.Add(entity.PublicArea);

            await _clientservice.CreateAsync(entity?.Client);

            return RedirectToAction(nameof(Index));
        }

        // GET: ClientController/Edit/5
        [HttpGet("cliente/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _clientservice.GetAsync(id));
        }

        // POST: ClientController/Edit/5
        [HttpPut("cliente/editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Core.Client.Model.Client entity)
        {
            await _clientservice.UpdateAsync(entity);

            return RedirectToAction(nameof(Index));
        }

        // GET: ClientController/Delete/5
        [HttpGet, ActionName("Delete")]
        public async Task<IActionResult> DeleteView(int id)
        {
            return View(await _clientservice.GetAsync(id));
        }

        // POST: ClientController/Delete/5
        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientservice.DeleteAsync(id);
            return await Index();
        }
    }
}
