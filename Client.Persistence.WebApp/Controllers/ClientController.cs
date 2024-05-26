using Client.Persistence.Core.Client.Service.Interface;
using Client.Persistence.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.Persistence.WebApp.Controllers
{
    public class ClientController : Controller
    {
        private string _filePath;
        private readonly IClientService? _clientservice;

        public ClientController(IWebHostEnvironment filePath, IClientService? clientservice)
        {
            _filePath = filePath.WebRootPath;
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
        public async Task<IActionResult> Create(PersistenceViewModel entity, IFormFile file)
        {
            if(!isValidImage(file))
                return View(entity);

            var name = await SaveFile(file);
            entity.Client.Logo = name;

            if(ModelState.IsValid){
                entity.Client.PublicAreas.Add(entity.PublicArea);
                await _clientservice.CreateAsync(entity?.Client);
                return RedirectToAction(nameof(Index));
            }
            else
                return View("Error");
        }

        // GET: ClientController/Edit/5
        [HttpGet("cliente/editar")]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _clientservice.GetAsync(id));
        }

        // POST: ClientController/Edit/5
        [HttpPost("cliente/editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Core.Client.Model.Client entity, IFormFile file)
        {
            string filePathName = $"{_filePath}\\images\\{entity.Logo}";

            if (!System.IO.File.Exists(filePathName)){

                if (!isValidImage(file))
                    return View(entity);

                var name = await SaveFile(file);
                entity.Logo = name;
            }            

            if (ModelState.IsValid){
                await _clientservice.UpdateAsync(entity);
                return RedirectToAction(nameof(Index));
            }
            else
                return View("Error");

        }

        // GET: ClientController/Delete/5
        [HttpGet("cliente/deletar"), ActionName("Delete")]
        public async Task<IActionResult> DeleteView(int id)
        {
            return View(await _clientservice.GetAsync(id));
        }

        // POST: ClientController/Delete/5
        [HttpPost("cliente/deletar"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var client = await _clientservice.GetAsync(id);
            string filePathName = $"{_filePath}\\images\\{client.Logo}";

            if(System.IO.File.Exists(filePathName))
                System.IO.File.Delete(filePathName);

            if(ModelState.IsValid){
                await _clientservice.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            else
                return View("Error");
        }

        private bool isValidImage(IFormFile file)
        {
            return file.ContentType switch
            {
                "image/jpeg" => true,
                "image/bmp" => true,
                "image/gif" => true,
                "image/png" => true,
                _ => false
            };
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var name = file.FileName;

            var filePath = $"{_filePath}\\images";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (var stream = System.IO.File.Create($"{filePath}\\{name}"))
            {
                await file.CopyToAsync(stream);
            };

            return name;
        }
    }
}
