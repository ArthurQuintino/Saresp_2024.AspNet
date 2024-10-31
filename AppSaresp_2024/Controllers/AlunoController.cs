using AppSaresp_2024.Models;
using AppSaresp_2024.Repository;
using AppSaresp_2024.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace AppSaresp_2024.Controllers
{
    public class AlunoController : Controller
    {
        private IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository) 
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public IActionResult CadastrarAluno() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarAluno(Aluno aluno)
        {
            if (ModelState.IsValid) 
            {
                _alunoRepository.Cadastrar(aluno);
            }
            return View();
        }
        public IActionResult Index()
        {
            return View(_alunoRepository.ObterTodosAlunos());
        }
    }
}
