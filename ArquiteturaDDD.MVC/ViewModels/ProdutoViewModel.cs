﻿

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArquiteturaDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
        [DisplayName("Disponivel ?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}