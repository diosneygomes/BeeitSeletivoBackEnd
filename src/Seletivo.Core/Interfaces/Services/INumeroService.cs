using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seletivo.Core.Interfaces.Services
{
    /// <summary>
    /// Interface que terá o papel de contrato de serviço de domínio da entidade Número
    /// </summary>
    public interface INumeroService
    {
        /// <summary>
        /// Método que será utilizado para calcular Fatorial
        /// </summary>
        Numero CalcularFatorial(Numero numero);
    }
}
