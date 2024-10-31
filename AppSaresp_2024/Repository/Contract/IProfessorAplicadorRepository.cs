using AppSaresp_2024.Models;

namespace AppSaresp_2024.Repository.Contract
{
    public interface IProfessorAplicadorRepository
    {
        //CRUD
        void Cadastrar(ProfessorAplicador professorAplicador);

        IEnumerable<ProfessorAplicador> ObterTodosProfessores();
    }
}
