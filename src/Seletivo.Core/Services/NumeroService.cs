using Seletivo.Core.Interfaces.Services;
using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seletivo.Core
{
    public class NumeroService : INumeroService
    {
        public Numero CalcularFatorial(Numero numero)
        {
            int fatorial = 1;
            for (int n = 1; n <= numero.Valor; n++)
            {
                fatorial *= n;
            }
            numero.Resultado = fatorial;
            return numero;
        }

        public int CalcularFatorial(int numero)
        {
            int fatorial = 1;
            for (int n = 1; n <= numero; n++)
            {
                fatorial *= n;
            }

                return fatorial;
        }

        public int Factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial_Recursion(number - 1);
        }

        public int Factorial_WhileLoop(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
