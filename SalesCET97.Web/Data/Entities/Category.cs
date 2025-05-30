﻿using System.ComponentModel.DataAnnotations;

namespace SalesCET97.Web.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string? Name { get; set; }
    }
}
