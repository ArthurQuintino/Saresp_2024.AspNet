using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppSaresp_2024.Models
{
    public class Aluno
    {
        [Display(Name = "Id do Aluno")]
        public int? IdAluno { get; set; }

        [Display(Name ="Nome Completo do Aluno")]
        [Required(ErrorMessage ="O campo nome é obrigatorio")]
        public string Nome {  get; set; }

        [Display(Name = "Email Completo do Aluno")]
        [Required(ErrorMessage = "O campo email é obrigatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Display(Name = "Telefone do Aluno")]
        [Required(ErrorMessage = "O campo telefone é obrigatorio")]
        public Int64 Telefone {  get; set; }

        [Display(Name = "Serie do Aluno")]
        [Required(ErrorMessage = "O campo serie é obrigatorio")]
        public string Serie { get; set; }

        [Display(Name = "Turma do Aluno")]
        [Required(ErrorMessage = "O campo turma é obrigatorio")]
        public string Turma { get; set; }

        [Display(Name = "Data de Nascimento do Aluno")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatorio")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
    }
}
