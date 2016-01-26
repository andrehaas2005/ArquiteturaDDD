

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ArquiteturaDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {

        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o Campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Preencha o Campo E-mail")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}