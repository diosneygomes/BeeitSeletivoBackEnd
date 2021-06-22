using Seletivo.Core.Interfaces.Services;
using Seletivo.Core.Models;

namespace Seletivo.Core
{
    /// <summary>
    /// Classe que implementa o contrato de serviço refente a entidade Número.
    /// </summary>
    public class NumeroService : INumeroService
    {
        public Numero CalcularFatorial(Numero numero)
        {
            int fatorial = 1;
            int aux = numero.Valor; 
            for (int n = 1; n <= numero.Valor; n++)
            {
                fatorial *= n;
                
                if (numero.Valor == aux)
                {
                    numero.Expressao = numero.Valor.ToString();
                    aux = 1;
                }
                if (n == numero.Valor)
                {
                    break;
                }
                numero.Expressao = numero.Expressao + " * " + (numero.Valor - n).ToString();

            }      
            numero.Resultado = fatorial;
            return numero;
        }
    }
}
