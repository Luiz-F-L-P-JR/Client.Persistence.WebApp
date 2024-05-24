using Client.Persistence.Core.Client.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Client.Persistence.WebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService? _clientservice;

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
            return View(await _clientservice.GetAsync(id));
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
        public async Task<IActionResult> Create(Core.Client.Model.Client entity)
        {
            if (ModelState.IsValid)
            {
                await _clientservice.CreateAsync(entity);
                return await Index();
            }

            return await Index();
        }

        // GET: ClientController/Edit/5
        [HttpGet("cliente/editar")]
        public async Task<IActionResult> Edit()
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPut("cliente/editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Core.Client.Model.Client entity)
        {
            if (ModelState.IsValid)
            {
                await _clientservice.UpdateAsync(entity);
                return await Index();
            }

            return await Index();
        }

        // GET: ClientController/Delete/5
        [HttpGet("cliente/deletar")]
        public async Task<IActionResult> Delete()
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpDelete("cliente/deletar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientservice.DeleteAsync(id);
            return await Index();
        }
    }
}
