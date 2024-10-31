using AppSaresp_2024.Models;

namespace AppSaresp_2024.Repository.Contract
{
    public interface IAlunoRepository
    {
        //CRUD
        void Cadastrar(Aluno aluno);

        IEnumerable<Aluno> ObterTodosAlunos();
    }
}
