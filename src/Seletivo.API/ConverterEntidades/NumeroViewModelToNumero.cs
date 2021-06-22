using Seletivo.API.ViewModels;
using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seletivo.API.ConverterEntidades
{
    public static class NumeroViewModelToNumero
    {
        public static Numero ConverterParaNumero(NumeroViewModel numeroViewModel)
        {
            Numero numero = new Numero();
            numero.Valor = numeroViewModel.Valor;
            return numero;
        }
    }
}
