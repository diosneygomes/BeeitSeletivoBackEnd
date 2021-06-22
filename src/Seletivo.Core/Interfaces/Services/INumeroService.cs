using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seletivo.Core.Interfaces.Services
{
    public interface INumeroService
    {
        Numero CalcularFatorial(Numero numero);
        int CalcularFatorial(int numero);
        int Factorial_Recursion(int numero);

        int Factorial_WhileLoop(int numero);
    }
}
