using GestaoEscolar.Data;
using GestaoEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoEscolar.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IESContext _context;

        public DepartamentoController(IESContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departamentos.OrderBy(c => c.Nome).ToListAsync());
        }
        //Get: Departamento/Create

        public IActionResult Create()
        {
            return View();
        }
        //POST:Departamento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create (Departamento departamento)

        {
            try
            {
                if(ModelState.IsValid)
                {
                    _context.Add(departamento);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(DbUpdateException)
            {
                ModelState.AddModelError("Erro", "Não foi possível inserir os dados.");
            }
            return View(departamento);
        }

    }
}
