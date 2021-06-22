using System;
using System.ComponentModel.DataAnnotations;

namespace Seletivo.API.ViewModels
{
    public class NumeroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1,100,ErrorMessage =("Favor digitar um valor entre 1 e 100"))]
        public int Valor { get; set; }
        
        public int Resultado { get; set; }
    }
}
