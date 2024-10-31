using AppSaresp_2024.Models;
using AppSaresp_2024.Repository;
using AppSaresp_2024.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace AppSaresp_2024.Controllers
{
    public class ProfessorAplicadorRepository : Controller
    {
        private IProfessorAplicadorRepository _professorAplicadorRepository;

        public ProfessorAplicadorRepository(IProfessorAplicadorRepository professorAplicadorRepository)
        {
            _professorAplicadorRepository = professorAplicadorRepository;
        }
        [HttpGet]
        public IActionResult CadastrarProfessor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarProfessor(ProfessorAplicador professor)
        {
            if (ModelState.IsValid)
            {
                _professorAplicadorRepository.Cadastrar(professor);
            }
            return View();
        }
        public IActionResult Index()
        {
            return View(_professorAplicadorRepository.ObterTodosProfessores());
        }
    }
}
