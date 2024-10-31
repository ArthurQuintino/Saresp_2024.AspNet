using System.ComponentModel.DataAnnotations;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppSaresp_2024.Models
{
    public class ProfessorAplicador   
    {   

        [Display(Name = "Id do Professor")]
        public int? IdProfessor { get; set; }

        [Display(Name = "Nome Completo do Professor")]
        [Required(ErrorMessage = "O campo nome é obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "CPF Completo do Professor")]
        [Required(ErrorMessage = "O campo CPF é obrigatorio")]
        public Int128 CPF { get; set; }

        [Display(Name = "RG do Professor")]
        [Required(ErrorMessage = "O campo RG é obrigatorio")]
        public Int64 RG { get; set; }

        [Display(Name = "Telefone do Professor")]
        [Required(ErrorMessage = "O campo telefone é obrigatorio")]
        public Int64 Telefone { get; set; }

        [Display(Name = "Data de Nascimento do Professor")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatorio")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
    }
}
