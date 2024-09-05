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

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _context.Emprestimos.Add(emprestimo);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        { 
            if(id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimosModel emprestimo = _context.Emprestimos.FirstOrDefault(x => x.Id == id);

            if(emprestimo == null) { NotFound(); }

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimoEditado) 
        {
            if(ModelState.IsValid)
            {
                _context.Emprestimos.Update(emprestimoEditado);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(emprestimoEditado);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0) return NotFound();

            EmprestimosModel emprestimo = _context.Emprestimos.FirstOrDefault(x => x.Id == id);

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _context.Emprestimos.Remove(emprestimo);
                _context.SaveChanges();

                TempData["MensagemSucesso"] = "Exclusão realizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
