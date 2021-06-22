using Seletivo.API.ViewModels;
using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seletivo.API.ConverterEntidades
{
    public class NumeroToNumeroViewModel
    {
        public static NumeroViewModel ConverterParaNumeroNumeroViewModel(Numero numero)
        {
            NumeroViewModel numeroViewModel = new NumeroViewModel();
            numeroViewModel.Id = numero.Id;
            numeroViewModel.Valor = numero.Valor;
            numeroViewModel.Resultado = numero.Resultado;
            return numeroViewModel;
        }
    }
}
