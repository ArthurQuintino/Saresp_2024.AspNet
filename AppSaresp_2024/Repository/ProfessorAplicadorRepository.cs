using AppSaresp_2024.Models;
using AppSaresp_2024.Repository.Contract;
using MySql.Data.MySqlClient;
using System.Data;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppSaresp_2024.Repository
{
    public class ProfessorAplicadorRepository : IProfessorAplicadorRepository
    {
        private readonly string _conexaoMySQL;

        public ProfessorAplicadorRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public void Cadastrar(ProfessorAplicador professorAplicador)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("Insert into ProfessorAplicador(IdProfessor, Nome, CPF, RG, Telefone, Nascimento) " +
                                                      " values(@IdProfessor, @Nome, @CPF, @RG, @Telefone, @Nascimento )", conexao);


                cmd.Parameters.Add("IdProfessor", MySqlDbType.VarChar).Value = professorAplicador.IdProfessor;
                cmd.Parameters.Add("Nome", MySqlDbType.VarChar).Value = professorAplicador.Nome;
                cmd.Parameters.Add("CPF", MySqlDbType.VarChar).Value = professorAplicador.CPF;
                cmd.Parameters.Add("RG", MySqlDbType.VarChar).Value = professorAplicador.RG;
                cmd.Parameters.Add("Telefone", MySqlDbType.VarChar).Value = professorAplicador.Telefone;
                cmd.Parameters.Add("Nascimento", MySqlDbType.VarChar).Value = professorAplicador.Nascimento.ToString("yyyy/MM/dd");

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public IEnumerable<ProfessorAplicador> ObterTodosProfessores()
        {
            List<ProfessorAplicador> ProfessorList = new List<ProfessorAplicador>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("Select * from ProfessorAplicador", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    ProfessorList.Add(
                        new ProfessorAplicador
                        {
                            IdProfessor = Convert.ToInt32(dr["IdProfessor"]),
                            Nome = (string)dr["Nome"],
                            CPF = Convert.ToInt64(dr["CPF"]),
                            RG =  Convert.ToInt64(dr["RG"]),
                            Telefone = Convert.ToInt64(dr["Telefone"]),
                            Nascimento =  Convert.ToDateTime(dr["Nascimento"])
                        }
                        );

                }
                return ProfessorList;
            }
        }
    }
}
