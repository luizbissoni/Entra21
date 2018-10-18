using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lista07MVC.Models
{
    public class Alunos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório!")]
        [MinLength(7,ErrorMessage="Nome deve conter no minimo 7 caracteres.")]
        [MaxLength(100,ErrorMessage="Nome deve conter no maximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Matricula é obrigatoria.")]
        [MaxLength(3,ErrorMessage="Matricula deve conter no maximo 3 caracteres.")]
        public string CodigoMatricula { get; set; }

        [Required(ErrorMessage="Nora 1 obrigatoria")]
        public double Nota_1 { get; set; }

        [Required(ErrorMessage = "Nora 2 obrigatoria")]
        public double Nota_2 { get; set; }

        [Required(ErrorMessage = "Nora 3 obrigatoria")]
        public double Nota_3 { get; set; }

        //[Required(ErrorMessage = "Preencha a frequencia.")]
        //[MaxLength(3, ErrorMessage = "Frequencia deve conter no maximo 3 caracteres")]
        public int Frequencia { get; set; }

        public string Situacao { get; set; }

    }
}