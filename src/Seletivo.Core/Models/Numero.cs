
namespace Seletivo.Core.Models
{
    /// <summary>
    /// Modelo de entidade que representa um Número 
    /// </summary>
    public class Numero : Entity
    {
        public int Valor { get; set; }
        public int Resultado { get; set; }
        public string Expressao { get; set; }
    }
}
