using EmprestimosLivro.Data;
using EmprestimosLivro.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivro.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmprestimoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _context.Emprestimos;

            return View(emprestimos);
        }
    }
}
