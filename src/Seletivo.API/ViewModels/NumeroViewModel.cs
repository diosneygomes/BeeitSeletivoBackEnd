using System;
using System.ComponentModel.DataAnnotations;

namespace Seletivo.API.ViewModels
{
    /// <summary>
    /// Entidade que representa uma View Model da entidade Número.
    /// </summary>
    public class NumeroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage =("O mínimo valor aceito é 1"))]
        public int Valor { get; set; }
        
        public int Resultado { get; set; }

        public string Expressao { get; set; }
    }
}
